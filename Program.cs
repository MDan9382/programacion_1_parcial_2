
using programacion_1_parcial_2.clases_parcial_2;

    albumes_rock ziggystdust = new albumes_rock ();
    ziggystdust.discografica_pub = "rca";
    ziggystdust.artista_pub = "david bowie";
    ziggystdust.duracion_pub = 2309;
    ziggystdust.titulo_pub = "the rise and fall of ziggy stardust and the spiders from mars";

    albumes_rock theblckprde = new albumes_rock ();
    theblckprde.discografica_pub = "reprise";
    theblckprde.artista_pub = "my chemical romance";
    theblckprde.duracion_pub = 3113;
    theblckprde.titulo_pub = "the black parade";

    peliculas matrix = new peliculas ();
    matrix.titulo_pub = "The Matrix";
    matrix.director_pub = "Wachowskis";
    matrix.anio_pub = 1999;
    matrix.duracion_pub = 8160;




    int selec = 0;
    tienda_de_discos[] inventario = { ziggystdust, theblckprde, matrix };
do
{
    selec = 0;
    Console.WriteLine("0)ejemplos clases \n1)ejemplo indexadores \n2)cerrar");
    int.TryParse(Console.ReadLine(), out selec);
    switch (selec)
    {
        case 0:
            {


                do
                {
                    selec = 0;
                    Console.WriteLine("seleccione los datos que desee mostrar");
                    Console.WriteLine("0)the rise and fall of ziggy stardust and the spiders from mars");
                    Console.WriteLine("1)the black parade \n2)the matrix \n3)mostrar todos \n9)salir");
                    int.TryParse(Console.ReadLine(), out selec);

                    switch (selec)
                    {
                        case 0:
                            {
                                ziggystdust.mostrardatos();
                                Console.ReadLine();
                            }
                            break;
                        case 1:
                            {
                                theblckprde.mostrardatos();
                                Console.ReadLine();
                            }
                            break;
                        case 2:
                            {
                                matrix.mostrardatos();
                                Console.ReadLine();
                            }
                            break;
                        case 3:
                            {
                                foreach (tienda_de_discos discos in inventario)
                                {
                                    discos.mostrardatos();
                                    Console.WriteLine();
                                }
                                Console.ReadLine();
                            }
                            break;
                    }
                    Console.Clear();
                } while (selec != 9);
            }
            break;
        case 1:
            {
                Console.Clear();
                indexadores indexadores = new indexadores();
                indexadores[0] = "mario";
                indexadores[1] = "daniel";
                indexadores[2] = "esquivel";
                for (int i = 0; i <= 3; i++)
                {
                    Console.WriteLine(indexadores[i]);
                }
                Console.ReadLine();
            }
            break;
    }
}while(selec != 2);