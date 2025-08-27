using Cifrador;

while (true)
        {
            Console.Clear();
            Console.WriteLine("==== Jeringozo ====");
            Console.WriteLine("1. Encriptar texto");
            Console.WriteLine("2. Desencriptar texto");
            Console.WriteLine("3. Salir");
            Console.Write("Elegir una opción: ");
            
            string opcion = Console.ReadLine()!;

            switch (opcion)
            {
                case "1":
                    Console.Write("Escribe un texto para encriptar: ");
                    string texto = Console.ReadLine()!;
                    string encriptado = Jeringozo.Encriptar(texto);
                    Console.WriteLine($"Texto encriptado:\n {encriptado}");
                    break;

                case "2":
                    Console.Write("Escribe un texto para desencriptar: ");
                    string textoEncriptado = Console.ReadLine()!;
                    string desencriptado = Jeringozo.Desencriptar(textoEncriptado);
                    Console.WriteLine($"Texto desencriptado:\n {desencriptado}");
                    break;

                case "3":
                    return;

                default:
                    Console.WriteLine("Opción inválida. Intenta de nuevo.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }