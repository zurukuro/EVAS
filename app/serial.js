const SerialPort = require('serialport');
const Readline = SerialPort.parsers.Readline;

class ArduinoDataRead {

    constructor(){
        this.listData = [];
    }

    get List() {
        return this.listData;
    }

    SetConnection(){

        SerialPort.list().then(listSerialDevices => {
            
            let listArduinoSerial = listSerialDevices.filter(serialDevice => {
                return serialDevice.vendorId == 2341 && serialDevice.productId == 43;
                //return serialDevice.vendorId == '2A03' && serialDevice.productId == '0043';
            });
            
            if (listArduinoSerial.length != 1){
                throw new Error("The Arduino was not connected or has many boards connceted");
            }

            console.log("Arduino found in the com %s", listArduinoSerial[0].comName);
             
            return  listArduinoSerial[0].comName;
            
        }).then(arduinoCom => {
            
            let arduino = new SerialPort(arduinoCom, {baudRate: 9600});
            
            const parser = new Readline();
            arduino.pipe(parser);
            
            parser.on('data', (data) => {
                inserirRegistro(data);
                this.listData.push(parseFloat(data));
            });
            
        }).catch(error => console.log(error));
    } 
}

const serial = new ArduinoDataRead();
serial.SetConnection();

module.exports.ArduinoData = {List: serial.List} 

var Connection = require('tedious').Connection;  
var config = {  
    userName: 'Duffoux',  
    password: 'Rick091295',  
    server: 'zackariel.database.windows.net',  
    // If you are on Microsoft Azure, you need this:  
    options: {encrypt: true, database: 'Duffoux'}  
};  
var connection = new Connection(config);  
connection.on('connect', function(err) {  
    if (err) {
        console.error('Erro ao tentar conexão com banco '+err);
    } else {
        console.log("Conectado com o SQL Server");  
    }
}); 


var Request = require('tedious').Request  
var TYPES = require('tedious').TYPES; 
var ultimoregistro = Date.now(); 

function inserirRegistro(valor) {  
	if (Date.now() - ultimoregistro >= 60 * 10000)
    {
        request = new Request("INSERT INTO TBLHISTORICO (TEMPERATURA, DATATEMP) values (@valor, DateAdd(Hour, -3, CURRENT_TIMESTAMP))", function (err) {
            if (err) {
                console.log(err);
            }
        });
        request.addParameter('valor', TYPES.Float, valor);
        connection.execSql(request);
        ultimoregistro = Date.now();
	}
	else
	{
        request = new Request("UPDATE TBLLEITURA SET LEITURA = @valor, DATATEMP = DateAdd(Hour, -3, CURRENT_TIMESTAMP);", function (err) {
            if (err) {
                console.log(err);
            }
        });
        request.addParameter('valor', TYPES.Float, valor);
        connection.execSql(request);
	}
}