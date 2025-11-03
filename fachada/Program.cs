// See https://aka.ms/new-console-template for more information
using fachada;

Console.WriteLine("Hello, World!");
/*
string archConv = AudioMixerTV.Convertir("saassa");
Console.WriteLine(archConv);

archConv = VideoFileTV.ConvierteAVF("asassa", "2");
Console.WriteLine(archConv);
*/

string archConv = VideoConverter.ConvertVideo("saassa",TipoVideo.AudioMixer);
Console.WriteLine(archConv);