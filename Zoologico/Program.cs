using System;
using Zoologico;

namespace Zoo
{
    class ProgZoo
    {
        static void Main(string[] args)
        {
            bool salir = false;

            do
            {
                Console.WriteLine("Bienvenido a mi Zoológico, aqui podras visitar y ver una gran variedad de animalaes y biodiversidad de ecositemas y podras aprender de cada uno de ellos");
                Console.WriteLine();
                Console.WriteLine("Seleccione un animal:");
                Console.WriteLine();
                Console.WriteLine("1) Ver informacion de León");
                Console.WriteLine("2) Ver informacion de Tigre");
                Console.WriteLine("3) Ver informacion de Jirafa");
                Console.WriteLine("4) Ver informacion de Mono");
                Console.WriteLine("5) Ver informacion de Cocodrilo");
                Console.WriteLine("6) Ver informacion de Elefante");
                Console.WriteLine("7) Ver informacion de Pingüino");
                Console.WriteLine("8) Ver informacion de Quetzal");
                Console.WriteLine("9) Ver informacion de Cebra");
                Console.WriteLine("10) Ver informacion de Aguila");
                Console.WriteLine("11) Ver informacion de Boa");
                Console.WriteLine("12) Ver informacion de Panda");
                Console.WriteLine("13) Ver informacion de Rinoceronte");
                Console.WriteLine("14) Ver informacion de Jaguar");
                Console.WriteLine("15) Ver informacion de Flamnco");
   

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        verAnimalLeon();
                        break;
                    case "2":
                        verAnimalTigre();
                        break;
                    case "3":
                        verAnimalJirafa();
                        break;
                    case "4":
                        verAnimalMono();
                        break;
                    case "5":
                        verAnimalCocodrilo();
                        break;
                    case "6":
                        verAnimalElefante();
                        break;
                    case "7":
                        verAnimalPingüino();
                        break;
                    case "8":
                        verAnimalQuetzal();
                        break;
                    case "9":
                        verAnimalCebra();
                        break;
                    case "10":
                        verAnimalAguila();
                        break;
                    case "11":
                        verAnimalBoa();
                        break;
                    case "12":
                        verAnimalPanda();
                        break;
                    case "13":
                        verAnimalRino();
                        break;
                    case "14":
                        verAnimalJaguar();
                        break;
                    case "15":
                        verAnimalFlamenco();
                        break;
                    default:
                        Console.WriteLine("No esta en la lista, intente de nuevo");
                        break;

                }
                if (!salir)
                {
                    Console.WriteLine("Precione una tecla para salir al menu de inicio del zoologico");
                    Console.ReadKey();
                    Console.Clear();

                }


            } while (!salir);


        }

        static void verAnimalLeon()
        {
            Leon zooLeon = new Leon("Zimba", "León", "Rugido", "Carnívoro");
            Console.WriteLine("LEON");
            Console.WriteLine("La especie es: " + zooLeon.Especie);
            Console.WriteLine("El nombre del animal es: " + zooLeon.Nombre);
            Console.WriteLine("El sonido que emite es: " + zooLeon.Sonido);
            Console.WriteLine("La especie come: " + zooLeon.Comida);
            Console.WriteLine();
        }

        static void verAnimalTigre()
        {
            Tigre zooTigre = new Tigre("Rayas", "Tigre", "Rugido", "Carnívoro");
            Console.WriteLine("TIGRE");
            Console.WriteLine("La especie es: " + zooTigre.Especie);
            Console.WriteLine("El nombre del animal es: " + zooTigre.Nombre);
            Console.WriteLine("El sonido que emite es: " + zooTigre.Sonido);
            Console.WriteLine("La especie come: " + zooTigre.Comida);
            Console.WriteLine();
        }

        static void verAnimalJirafa()
        {
            Jirafa zooJirafa = new Jirafa("Jirafon", "Jirafa", "No produce sonido", "Hervivoro", "Africa");
            Console.WriteLine("JIRAFA");
            Console.WriteLine("La especie es: " + zooJirafa.Especie);
            Console.WriteLine("El nombre de la Jirafa es: " + zooJirafa.Nombre);
            Console.WriteLine("El sonido que emite es: " + zooJirafa.Sonido);
            Console.WriteLine("La especie come: " + zooJirafa.Comida);
            Console.WriteLine("Habita en: " + zooJirafa.Lugar);
            Console.WriteLine();
        }

        static void verAnimalMono()
        {
            Mono zooMono = new Mono("Jorge", "Simio", "gruñidos, ladrido, rugido, ronroneo", "Hervivoro", "Africa,America y Asia");
            Console.WriteLine("MONO");
            Console.WriteLine("La especie es: " + zooMono.Especie);
            Console.WriteLine("El nombre del animal es: " + zooMono.Nombre);
            Console.WriteLine("El sonido que emite es: " + zooMono.Sonido);
            Console.WriteLine("La especie come: " + zooMono.Comida);
            Console.WriteLine("Habita en: " + zooMono.Lugar);
            Console.WriteLine();
        }

        static void verAnimalCocodrilo()
        {
            Cocodrilo zooCocodrilo = new Cocodrilo("Mandibulas", "Reptil", "gruñidos,", "omnívoro", "Africa,America y Asia");
            Console.WriteLine("COCODRILO");
            Console.WriteLine("La especie es: " + zooCocodrilo.Especie);
            Console.WriteLine("El nombre del animal es: " + zooCocodrilo.Nombre);
            Console.WriteLine("El sonido que emite es: " + zooCocodrilo.Sonido);
            Console.WriteLine("La especie come: " + zooCocodrilo.Comida);
            Console.WriteLine("Habita en: " + zooCocodrilo.Lugar);
            Console.WriteLine();
        }

        static void verAnimalElefante()
        {
            Elefante zooElefante = new Elefante("Dubi", "Elefante/Mamifero", "Barrita(Sonido hemitido por la tromapa)", "omnívoro", "Africa y Asia");
            Console.WriteLine("ELEFANTE");
            Console.WriteLine("La especie es: " + zooElefante.Especie);
            Console.WriteLine("El nombre del animal es: " + zooElefante.Nombre);
            Console.WriteLine("El sonido que emite es: " + zooElefante.Sonido);
            Console.WriteLine("La especie come: " + zooElefante.Comida);
            Console.WriteLine("Habita en: " + zooElefante.Lugar);
            Console.WriteLine();
        }

        static void verAnimalPingüino()
        {
            Pingüino zooPingüino = new Pingüino("Pingu", "Ave", "Graznan", "omnívoro", "Antartita y Sur de America ");
            Console.WriteLine("PINGUINO");
            Console.WriteLine("La especie es: " + zooPingüino.Especie);
            Console.WriteLine("El nombre del animal es: " + zooPingüino.Nombre);
            Console.WriteLine("El sonido que emite es: " + zooPingüino.Sonido);
            Console.WriteLine("La especie come: " + zooPingüino.Comida);
            Console.WriteLine("Habita en: " + zooPingüino.Lugar);
            Console.WriteLine();
        }

        static void verAnimalQuetzal()
        {
            Quetzal zooQuetzal = new Quetzal("Chapinsito", "Ave", "Silvido o canto", "omnívoro", "Centroamerica y zonas de Mexico en Yucatan y Chiapas");
            Console.WriteLine("QUETZAL");
            Console.WriteLine("La especie es: " + zooQuetzal.Especie);
            Console.WriteLine("El nombre del animal es: " + zooQuetzal.Nombre);
            Console.WriteLine("El sonido que emite es: " + zooQuetzal.Sonido);
            Console.WriteLine("La especie come: " + zooQuetzal.Comida);
            Console.WriteLine("Habita en: " + zooQuetzal.Lugar);
            Console.WriteLine();
        }

        static void verAnimalCebra()
        {
            Cebra zooCebra = new Cebra("Camilo", "Equino", "Bramn", "Hervivoro", "Centro y sur de Africa");
            Console.WriteLine("CEBRA");
            Console.WriteLine("La especie es: " + zooCebra.Especie);
            Console.WriteLine("El nombre del animal es: " + zooCebra.Nombre);
            Console.WriteLine("El sonido que emite es: " + zooCebra.Sonido);
            Console.WriteLine("La especie come: " + zooCebra.Comida);
            Console.WriteLine("Habita en: " + zooCebra.Lugar);
            Console.WriteLine();
        }

        static void verAnimalAguila()
        {
            Aguila zooAguila = new Aguila("Chuck", "Ave", "Graznar o silvido", "Omnivoro", "Norte America");
            Console.WriteLine("AGUILA");
            Console.WriteLine("La especie es: " + zooAguila.Especie);
            Console.WriteLine("El nombre del animal es: " + zooAguila.Nombre);
            Console.WriteLine("El sonido que emite es: " + zooAguila.Sonido);
            Console.WriteLine("La especie come: " + zooAguila.Comida);
            Console.WriteLine("Habita en: " + zooAguila.Lugar);
            Console.WriteLine();
        }

        static void verAnimalBoa()
        {
            Boa zooBoa = new Boa("Esmeralda", "Serpiente", "No hemite sonido", "Carnivora", "America");
            Console.WriteLine("BOA");
            Console.WriteLine("La especie es: " + zooBoa.Especie);
            Console.WriteLine("El nombre del animal es: " + zooBoa.Nombre);
            Console.WriteLine("El sonido que emite es: " + zooBoa.Sonido);
            Console.WriteLine("La especie come: " + zooBoa.Comida);
            Console.WriteLine("Habita en: " + zooBoa.Lugar);
            Console.WriteLine();
        }

        static void verAnimalPanda()
        {
            Panda zooPanda = new Panda("Pou El guerrero Dragon ", "Oso", "Gruñe", "Omnivoro", "Asia, Principalmete ne China");
            Console.WriteLine("PANDA");
            Console.WriteLine("La especie es: " + zooPanda.Especie);
            Console.WriteLine("El nombre del animal es: " + zooPanda.Nombre);
            Console.WriteLine("El sonido que emite es: " + zooPanda.Sonido);
            Console.WriteLine("La especie come: " + zooPanda.Comida);
            Console.WriteLine("Habita en: " + zooPanda.Lugar);
            Console.WriteLine();
        }

        static void verAnimalRino()
        {
            Rinoceronte zooRino = new Rinoceronte("Señora Tay", "Rinoceronte", "Gruñe", "Hervivoro", "Africa y Asia");
            Console.WriteLine("RINOCERONTE");
            Console.WriteLine("La especie es: " + zooRino.Especie);
            Console.WriteLine("El nombre del animal es: " + zooRino.Nombre);
            Console.WriteLine("El sonido que emite es: " + zooRino.Sonido);
            Console.WriteLine("La especie come: " + zooRino.Comida);
            Console.WriteLine("Habita en: " + zooRino.Lugar);
            Console.WriteLine();

        }

        static void verAnimalJaguar()
        {
            Jaguar zooJaguar = new Jaguar("Manchitas", "Felino", "Gruñe y ruje", "Carnivoro", "Centro y sur america");
            Console.WriteLine("JAGUAR");
            Console.WriteLine("La especie es: " + zooJaguar.Especie);
            Console.WriteLine("El nombre del animal es: " + zooJaguar.Nombre);
            Console.WriteLine("El sonido que emite es: " + zooJaguar.Sonido);
            Console.WriteLine("La especie come: " + zooJaguar.Comida);
            Console.WriteLine("Habita en: " + zooJaguar.Lugar);
            Console.WriteLine();
        }

        static void verAnimalFlamenco()
        {
            Flamenco zooFlamneco = new Flamenco("Jesse Pinkman", "Ave", "Silvido o canto", "Omnivoro", "América, sur de Europa, áfrica y Asia");
            Console.WriteLine("FLAMENCO");
            Console.WriteLine("La especie es: " + zooFlamneco.Especie);
            Console.WriteLine("El nombre del animal es: " + zooFlamneco.Nombre);
            Console.WriteLine("El sonido que emite es: " + zooFlamneco.Sonido);
            Console.WriteLine("La especie come: " + zooFlamneco.Comida);
            Console.WriteLine("Habita en: " + zooFlamneco.Lugar);
            Console.WriteLine();
        }
    }

}





