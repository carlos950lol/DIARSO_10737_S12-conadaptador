// See https://aka.ms/new-console-template for more information
using adaptador;

string res = Aplicacion.ResultadoXML();
string adap = Adaptador.XMLtoJSON(res);
string res2 = Contabilidad.ResultadoWord();
string adap2 = Adaptador.WordtoExcel(res2);
string adap3= Adaptador.WordtoExcel("2");
Biblioteca.RecibeJSON(adap);
ventas.RecibeXLSX(adap2);
ventas.RecibeXLSX(adap3);


