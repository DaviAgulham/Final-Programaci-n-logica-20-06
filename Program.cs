using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matrizProduct = CargarProductos();
            int[,] matrizPrice = CargarPrecioStock();
            string[,] matrizClient = CargarCliente();
            string[] indiceProduct = CargarIP();
            string[] indiceClient = CargarIC();
            showSwitch(0, matrizProduct, matrizPrice, matrizClient, indiceProduct, indiceClient);
        }

        /// <summary>
        /// Muestra las opciones del menu principal
        /// </summary>
        static void showMenu()
        {
            Console.WriteLine("***********Bienvenido Anime Patisserie*************\n");
            Console.WriteLine("Menu de opciones");
            Console.WriteLine("1. Agregar, borrar o editar productos");
            Console.WriteLine("2. Modificacion de clientes");
            Console.WriteLine("3. Informaciones almacenadas");
            Console.WriteLine("4. Resumen de clientes del mes");
            Console.WriteLine("5. Salir");
        }

        /// <summary>
        /// Carga el menu principal y sus opciones
        /// </summary>
        /// <param name="chosenNumber"></param>
        /// <param name="matrizProduct"></param>
        /// <param name="matrizPrice"></param>
        /// <param name="matrizClient"></param>
        /// <param name="indiceProduct"></param>
        /// <param name="indiceClient"></param>
        static void showSwitch(int chosenNumber, string[,] matrizProduct, int[,] matrizPrice, string[,] matrizClient, string[] indiceProduct, string[] indiceClient)
        {
            int ChosenOption;
            do
            {
                showMenu();
                chosenNumber = numberChosen("Por favor elegir opcíon", 1, 5);
                ChosenOption = chosenNumber;
                switch (chosenNumber)
                {
                    case 1:
                        MenuCase1(matrizProduct, matrizPrice, indiceProduct);
                        break;
                    case 2:
                        MenuCase2(matrizClient, indiceClient);
                        break;
                    case 3:
                        ShowArrayProStock(matrizProduct, matrizPrice, indiceProduct);
                        break;
                    case 4:
                        ShowArrayCliente(matrizClient, indiceClient, "Presione cualquier tecla para volver al menu");
                        break;
                    case 5:
                        Console.WriteLine("Estas seguro que quieres salir? :(\n");
                        Console.WriteLine("Digite Si para salir o No para seguir en el sistema\n");
                        string Exit = Console.ReadLine().ToLower().Trim();
                        while (Exit != "no" && Exit != "si")
                        {
                            Console.WriteLine("Por favor ingresar solamente Si o No");
                            Exit = Console.ReadLine();
                        }
                        if (Exit == "no")
                        {
                            ChosenOption = 0;
                            Console.WriteLine("Presione cualquier tecla para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        if (Exit == "si")
                        {
                            Console.WriteLine("Que pena, hasta la proxima ;-;");
                            Console.WriteLine("Presione cualquier tecla para cerrar el sistema");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                }
            } while (ChosenOption != 5);
        }

        /// <summary>
        /// Carga los datos de los productos
        /// </summary>
        /// <returns></returns>
        static string[,] CargarProductos()
        {
            string[,] aux = new string[15, 3]
            {
                {"1", "Rogel Sayajin", "no" },
                {"2", "Mousse Naruto", "si" },
                {"3", "Torta Akatsuki", "no"},
                {string.Empty, string.Empty, string.Empty},
                {"5", "Cheesecake Cowboy Bebop", "no"},
                {"6", "Steins Lemon Pie Gate", "no"},
                {string.Empty , string.Empty, string.Empty},
                {"8", "Marquise No Kyojin", "si"},
                {string.Empty, string.Empty, string.Empty},
                {"10", "One piece de Tarteleta", "si"},
                {"11", "Hunter Crumble", "si"},
                {string.Empty, string.Empty, string.Empty},
                {"13", "Tiramisu Berserk","no"},
                {"14", "Alfajor Slayer", "no"},
                {"15", "Jojo Flan Adventure","no"}
            };
            return aux;
        }

        /// <summary>
        /// Carga los datos de losprecios de productos y el stock en formato int 
        /// </summary>
        /// <returns></returns>
        static int[,] CargarPrecioStock()
        {
            int[,] aux = new int[15, 3]
            {
                {1, 300, 5},
                {2, 250, 6},
                {3, 375, 2},
                {4, -1, -1},
                {5, 350, 3},
                {6, 400, 7},
                {7 ,-1, -1},
                {8, 300, 1},
                {9 ,-1, -1},
                {10, 375, 3},
                {11, 350, 6},
                {12, -1, -1},
                {13, 450, 7},
                {14, 150, 14},
                {15, 250, 9}
            };
            return aux;
        }

        /// <summary>
        /// Carga los datos de los clientes
        /// </summary>
        /// <returns></returns>
        static string[,] CargarCliente()
        {
            string[,] aux = new string[10, 6]
            {
                {"1", "Roberto", "Gonzalez", "Corrientes 3100", "56757314", "325"},
                {string.Empty , string.Empty, string.Empty, string.Empty , string.Empty, string.Empty},
                {string.Empty , string.Empty, string.Empty, string.Empty , string.Empty, string.Empty},
                {"4", "Joaquin","Rodriguez", "9 de julio 400", "19535231", "200"},
                {"5", "Ana", "Romero", "adolfo alsina 200", "66063151", "189"},
                {"6", "Karol", "Flores", "sarmiento 2300", "73383953", "150"},
                {string.Empty , string.Empty, string.Empty, string.Empty , string.Empty, string.Empty},
                {"8", "Martina", "Perez", "guardia vieja 127", "61888535", "80"},
                {"9", "Jorge", "Jorgito", "nazca 3178", "65484777", "50"},
                {string.Empty , string.Empty, string.Empty, string.Empty , string.Empty, string.Empty}
            };
            return aux;
        }

        /// <summary>
        /// Carga el indice de los productos
        /// </summary>
        /// <returns></returns>
        static string[] CargarIP()
        {
            string[] aux = new string[5]
            {"Id Producto","Producto","Vegano?","Precio","Stock"};
            return aux;
        }

        /// <summary>
        /// Carga el indice de clientes
        /// </summary>
        /// <returns></returns>
        static string[] CargarIC()
        {
            string[] aux = new string[6]
            {"Id Cliente","Nombre","Apellido","Direccion","Telefono","Numero de compras"};
            return aux;
        }

        /// <summary>
        /// Muestra los datos de los productos registrados y los pendientes
        /// </summary>
        /// <param name="matrizProduct"></param>
        /// <param name="matrizPrice"></param>
        /// <param name="indiceProduct"></param>
        public static void ShowArrayProStock(string[,] matrizProduct, int[,] matrizPrice, string[] indiceProduct)
        {
            int promedioPrecios = 0;
            int promedioFinal = 0;

            Console.WriteLine("Informaciones almacenadas de los productos y del stock \n");
            for (int i = 0; i < indiceProduct.Length; i++)
            {
                Console.Write("|");
                Console.Write($"{indiceProduct[i],-22} ");
            }
            for (int fMP = 0; fMP < matrizProduct.GetLength(0); fMP++)
            {
                for (int fP = 0; fP < matrizPrice.GetLength(0); fP++)
                {
                    if (matrizProduct[fMP, 0] == matrizPrice[fP, 0].ToString())
                    {
                        Console.Write("|");
                        for (int cMP = 0; cMP < matrizProduct.GetLength(1); cMP++)
                        {
                            Console.Write($"{matrizProduct[fMP, cMP],-23}|");
                        }
                        for (int cP = 1; cP < matrizPrice.GetLength(1); cP++)
                        {
                            promedioPrecios = promedioPrecios + matrizPrice[fP, 1];
                            Console.Write($"{matrizPrice[fP, cP],-23}|");
                        }
                        Console.WriteLine();
                    }
                }
            }
            promedioFinal = promedioPrecios / 15;
            Console.WriteLine($"El promedio de los precios de la tienda es de ${promedioFinal}ARS, es un excelente promedio!");
            Console.WriteLine("Presionar alguna tecla para volver al menu");
            Console.ReadLine();
            Console.Clear();
        }

        /// <summary>
        /// Muestra los datos de los clientes registrados y espacios pendientes
        /// </summary>
        /// <param name="matrizClient"></param>
        /// <param name="indiceClient"></param>
        public static void ShowArrayCliente(string[,] matrizClient, string[] indiceClient, string mensage)
        {
            Console.WriteLine("Informaciones de los mejores 10 clientes del mes");
            for (int i = 0; i < indiceClient.Length; i++)
            {
                Console.Write("|");
                Console.Write($"{indiceClient[i],-16} ");
            }
            Console.WriteLine();
            for (int filaC = 0; filaC < matrizClient.GetLength(0); filaC++)
            {
                Console.Write("|");
                for (int cC = 0; cC < matrizClient.GetLength(1); cC++)
                {
                    Console.Write($"{matrizClient[filaC, cC],-17}|");
                }
                Console.WriteLine();
            }
            Console.WriteLine(mensage);
            Console.ReadLine();
            Console.Clear();
        }

        //************************************************************************************
        //Parte del Producto
        //************************************************************************************

        /// <summary>
        /// Menu de opciones de los productos
        /// </summary>
        /// <param name="matrizProduct"></param>
        /// <param name="matrizPrice"></param>
        /// <param name="indiceProduct"></param>
        public static void MenuCase1(string[,] matrizProduct, int[,] matrizPrice, string[] indiceProduct)
        {
            int auxiliar;
            ShowMenu2();
            auxiliar = numberChosen("Por favor elegir opcíon", 1, 3);
            switch (auxiliar)
            {
                case 1:
                    Console.WriteLine("Agregar productos");
                    AddProducts(matrizProduct, matrizPrice);
                    break;
                case 2:
                    Console.WriteLine("Eliminar productos");
                    EliminateProduct(matrizProduct, matrizPrice, indiceProduct);
                    break;
                case 3:
                    Console.WriteLine("Volver al menu principal");
                    break;
            }
        }

        /// <summary>
        /// Menu de los productos
        /// </summary>
        public static void ShowMenu2()
        {
            Console.WriteLine("Menu de opciones");
            Console.WriteLine("1. Para agregar los productos");
            Console.WriteLine("2. Para Eliminar los productos");
            Console.WriteLine("3. Volver al menu");
        }

        /// <summary>
        /// Agrega los datos finales del producto
        /// </summary>
        /// <param name="matrizProduct"></param>
        /// <param name="matrizPrice"></param>
        public static void AddProducts(string[,] matrizProduct, int[,] matrizPrice)
        {
            bool freeSpace = true;
            int emptySpace = 1;
            bool addOther = true;
            string askUser;

            do
            {
                Console.Clear();
                freeSpace = false;
                for (int i = 0; i < matrizProduct.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizPrice.GetLength(0); j++)
                    {
                        if (string.IsNullOrEmpty(matrizProduct[i, 0]))
                        {
                            emptySpace = i;
                            freeSpace = true;
                        }
                        else if (i == matrizProduct.GetLength(0) - 1 && freeSpace != true)
                        {
                            freeSpace = false;
                            break;
                        }
                    }
                    if (freeSpace == true)
                    {
                        AddNewProduct("Ingresar numero de indentificación del producto", 0, emptySpace, matrizProduct);

                        AddNewProduct("Ingresar nombre del producto", 1, emptySpace, matrizProduct);

                        MalditosVeganos("El producto es apto para veganos?", 2, emptySpace, matrizProduct);

                        AddPriceStock("cuanto cuesta el producto?", 1, emptySpace, matrizPrice);

                        AddPriceStock("Cuantos productos hay en stock", 2, emptySpace, matrizPrice);

                        Console.WriteLine("Desea agregar otro producto? Escribir si para seguir o no para volver al menu");
                        askUser = ValidarSiNo(Console.ReadLine().ToLower().Trim());

                        if (askUser == "no")
                        {
                            addOther = false;
                            break;
                            Console.Clear();
                        }
                    }
                }
            } while (addOther == true);
        }

        /// <summary>
        /// Agrega datos del producto 
        /// </summary>
        /// <param name="mensage"></param>
        /// <param name="columna"></param>
        /// <param name="fila"></param>
        /// <param name="matrizProduct"></param>
        public static void AddNewProduct(string mensage, int columna, int fila, string[,] matrizProduct)
        {
            string information;
            bool repeat = true;
            Console.WriteLine(mensage);

            if (columna == 0)
            {
                information = NumericValidation(information = Console.ReadLine());
            }
            else
            {
                information = StringValidation(information = Console.ReadLine());
            }
            while (repeat == true)
            {
                repeat = false;
                for (int i = 0; i < matrizProduct.GetLength(0); i++)
                {
                    if (matrizProduct[i, columna] == information)
                    {
                        repeat = true;
                    }
                }
                if (repeat == true)
                {
                    Console.WriteLine("Perdon, pero ingresaste un dato que ya existe");
                    Console.WriteLine(mensage);

                    if (columna == 0)
                    {
                        information = NumericValidation(information = Console.ReadLine());
                    }
                    else
                    {
                        information = StringValidation(information = Console.ReadLine());
                    }
                }
            }
            matrizProduct[fila, columna] = information;
        }

        /// <summary>
        /// Agrega datos a la columna si es apto para vegano
        /// </summary>
        /// <param name="mensage"></param>
        /// <param name="columna"></param>
        /// <param name="fila"></param>
        /// <param name="matrizProduct"></param>
        public static void MalditosVeganos(string mensage, int columna, int fila, string[,] matrizProduct)
        {
            string information;
            Console.WriteLine(mensage);

            if (columna == 0)
            {
                information = NumericValidation(information = Console.ReadLine());
            }
            else
            {
                information = ValidarSiNo(information = Console.ReadLine());
            }
            matrizProduct[fila, columna] = information;
        }

        /// <summary>
        /// Agregar datos a los precios y stock
        /// </summary>
        /// <param name="mensage"></param>
        /// <param name="columna"></param>
        /// <param name="fila"></param>
        /// <param name="matrizPrice"></param>
        public static void AddPriceStock(string mensage, int columna, int fila, int[,] matrizPrice)
        {
            int convertido;
            Console.WriteLine(mensage);

            while (!int.TryParse(Console.ReadLine(), out convertido) && convertido < 700)
            {
                Console.WriteLine("El dato ingresado debe ser un número aceptable. Por favor reingrese el dato");
                Console.WriteLine();
                Console.Clear();
            }
            matrizPrice[fila, columna] = convertido;
        }

        /// <summary>
        /// Buscar producto por el ID
        /// </summary>
        /// <param name="auxiliarFila"></param>
        /// <param name="matrizProduct"></param>
        /// <returns></returns>
        public static int SearchProduct(int auxiliarFila, string[,] matrizProduct)
        {
            string modificarProduct;
            bool haveID = false;

            while (haveID == false)
            {
                Console.WriteLine("Por favor, ingresar el ID del producto");
                modificarProduct = StringValidation(Console.ReadLine());

                for (int i = 0; i < matrizProduct.GetLength(0); i++)
                {
                    if (matrizProduct[i, 0] == modificarProduct)
                    {
                        haveID = true;
                        auxiliarFila = i;
                    }
                }
                if (haveID == false)
                {
                    Console.WriteLine("El ID solicitado no fue encontrado en el sistema \nPor favor ingresar el ID nuevamente");
                    Console.WriteLine("Presione alguna tecla para continuar");
                    Console.ReadKey();
                }
            }
            Console.Clear();
            return auxiliarFila;
        }

        /// <summary>
        /// Eliminar productos
        /// </summary>
        /// <param name="matrizProduct"></param>
        /// <param name="matrizPrice"></param>
        /// <param name="indiceProduct"></param>
        public static void EliminateProduct(string[,] matrizProduct, int[,] matrizPrice, string[] indiceProduct)
        {
            int filaProducto = 0;
            string confirmar;

            filaProducto = SearchProduct(filaProducto, matrizProduct);
            ShowArrayProStock(matrizProduct, matrizPrice, indiceProduct);
            Console.WriteLine();
            Console.WriteLine("¿Desea eliminar este producto? Escriba si o no");
            confirmar = ValidarSiNo(Console.ReadLine());
            Console.WriteLine();

            if (confirmar == "si")
            {
                matrizProduct[filaProducto, 0] = string.Empty;
                matrizProduct[filaProducto, 1] = string.Empty;
                matrizProduct[filaProducto, 2] = string.Empty;
                matrizPrice[filaProducto, 0] = 0;
                matrizPrice[filaProducto, 1] = 0;
                matrizPrice[filaProducto, 2] = 0;


                Console.WriteLine("El producto se ha eliminado correctamente");
                Console.ReadKey();
                Console.WriteLine();
                ShowArrayProStock(matrizProduct, matrizPrice, indiceProduct);
            }
        }

        //************************************************************************************
        //Parte del cliente
        //************************************************************************************

        /// <summary>
        /// Menu para elegir opciones relacionadas al cliente
        /// </summary>
        /// <param name="matrizClient"></param>
        /// <param name="indiceClient"></param>
        public static void MenuCase2(string[,] matrizClient, string[] indiceClient)
        {
            int aux;
            ShowClientMenu();
            aux = numberChosen("Por favor elegir", 1, 3);
            switch (aux)
            {
                case 1:
                    AddClient(matrizClient, indiceClient);
                    break;
                case 2:
                    DeleteClient(matrizClient, indiceClient);
                    break;
                case 3:
                    Console.WriteLine("Volver para el menu principal");
                    Console.Clear();
                    break;
            }
        }

        /// <summary>
        /// Menu del cliente
        /// </summary>
        public static void ShowClientMenu()
        {
            Console.WriteLine("Menu de opciones del cliente");
            Console.WriteLine("1. Para agregar clientes pendientes");
            Console.WriteLine("2. Para Eliminar determinado cliente");
            Console.WriteLine("3. Volver al menu");
        }

        /// <summary>
        /// Funcion para agregar cliente nuevo
        /// </summary>
        /// <param name="matrizClient"></param>
        /// <param name="indiceClient"></param>
        public static void AddClient(string[,] matrizClient, string[] indiceClient)
        {
            bool freeSpace = true;
            int emptySpace = 1;
            bool addOther = true;
            string askUser;

            do
            {
                freeSpace = false;
                for (int i = 0; i < matrizClient.GetLength(0); i++)
                {
                    if (string.IsNullOrEmpty(matrizClient[i, 0]))
                    {
                        emptySpace = i;
                        freeSpace = true;
                    }
                    else if (i == matrizClient.GetLength(0) - 1 && freeSpace != true)
                    {
                        freeSpace = false;
                        break;
                    }
                    if (freeSpace == true)
                    {
                        AddNewClient("Ingresar numero de indentificación del cliente", 0, emptySpace, matrizClient);

                        AddNewClient("Ingresar nombre del cliente", 1, emptySpace, matrizClient);

                        AddNewClient("Ingresar el apellido del cliente", 2, emptySpace, matrizClient);

                        AddNewClient("Ingresar la direccion del cliente", 3, emptySpace, matrizClient);

                        AddNewClient("Ingresar el telefono del cliente", 4, emptySpace, matrizClient);

                        AddNewClient("Cual es el total de compras efectuadas por el cliente", 5, emptySpace, matrizClient);

                        Console.WriteLine("Desea agregar otro producto? Escribir si para seguir o no para volver al menu");
                        askUser = ValidarSiNo(Console.ReadLine().ToLower().Trim());

                        if (askUser == "no")
                        {
                            addOther = false;
                            break;
                            Console.Clear();
                        }
                    }
                }
            } while (addOther == true);
        }

        /// <summary>
        /// Sirve para agregar un nuevo cliente
        /// </summary>
        /// <param name="mensage"></param>
        /// <param name="columna"></param>
        /// <param name="fila"></param>
        /// <param name="matrizClient"></param>
        public static void AddNewClient(string mensage, int columna, int fila, string[,] matrizClient)
        {
            string information;
            bool repeat = true;

            Console.WriteLine(mensage);

            if (columna == 0)
            {
                information = NumericValidation(information = Console.ReadLine());
            }
            else
            {
                information = StringValidation(information = Console.ReadLine());
            }

            while (repeat == true)
            {

                repeat = false;
                for (int i = 0; i < matrizClient.GetLength(0); i++)
                {
                    if (matrizClient[i, columna] == information)
                    {
                        repeat = true;
                    }
                }
                if (repeat == true)
                {
                    Console.WriteLine("Perdon, pero ingresaste un dato que ya existe");
                    Console.WriteLine(mensage);

                    if (columna == 0)
                    {
                        information = NumericValidation(information = Console.ReadLine());
                    }
                    else
                    {
                        information = StringValidation(information = Console.ReadLine());
                    }
                }
            }
            matrizClient[fila, columna] = information;
        }

        /// <summary>
        /// Busca el cliente por el ID
        /// </summary>
        /// <param name="auxiliarFila"></param>
        /// <param name="matrizClient"></param>
        /// <param name="indiceClient"></param>
        /// <returns></returns>
        public static int SearchClientID(int auxiliarFila, string[,] matrizClient, string[] indiceClient)
        {
            string modificarClient;
            bool haveID = false;

            while (haveID == false)
            {
                Console.Clear();

                Console.WriteLine("Por favor, ingresar el ID del cliente");
                modificarClient = StringValidation(Console.ReadLine());

                for (int i = 0; i < matrizClient.GetLength(0); i++)
                {
                    if (matrizClient[i, 0] == modificarClient)
                    {
                        haveID = true;
                        auxiliarFila = i;
                    }
                }
                if (haveID == false)
                {
                    Console.WriteLine("El ID solicitado no fue encontrado en el sistema \nPor favor ingresar el ID nuevamente");
                    Console.WriteLine("Presione alguna tecla para continuar");
                    Console.ReadKey();
                }
            }
            return auxiliarFila;
        }

        /// <summary>
        /// Sirve para deletar los clientes
        /// </summary>
        /// <param name="matrizClient"></param>
        /// <param name="indiceClient"></param>
        public static void DeleteClient(string[,] matrizClient, string[] indiceClient)
        {
            int filaProducto = 0;
            string confirmar;

            filaProducto = SearchClientID(filaProducto, matrizClient, indiceClient);

            ShowArrayCliente(matrizClient, indiceClient, "Presione cualquier tecla para avanzar");
            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("¿Estas seguro que quieres eliminar este cliente? Escriba si o no");
            confirmar = ValidarSiNo(Console.ReadLine());
            Console.WriteLine();

            if (confirmar == "si")
            {
                matrizClient[filaProducto, 0] = string.Empty;
                matrizClient[filaProducto, 1] = string.Empty;
                matrizClient[filaProducto, 2] = string.Empty;
                matrizClient[filaProducto, 3] = string.Empty;
                matrizClient[filaProducto, 4] = string.Empty;
                matrizClient[filaProducto, 5] = string.Empty;


                Console.WriteLine("El cliente fue eliminado correctamente");
                Console.ReadKey();
                Console.WriteLine();
                ShowArrayCliente(matrizClient, indiceClient, "Presionar cualquier tecla para volver al menu");
            }
        }

        //************************************************************************************
        //Verificaciones
        //************************************************************************************

        /// <summary>
        /// Valida los numeros ingresados en los menus
        /// </summary>
        /// <param name="mensage"></param>
        /// <param name="numMin"></param>
        /// <param name="numMax"></param>
        /// <returns></returns>
        static int numberChosen(string mensage, int numMin, int numMax)
        {
            int aux;
            Console.WriteLine(mensage);

            while (!int.TryParse(Console.ReadLine(), out aux) || aux < numMin || aux > numMax)
            {
                Console.WriteLine("Por favor reingresar un valor correcto");
            }
            Console.Clear();
            return aux;
        }

        /// <summary>
        /// Valida si el dato ingresado al sistemas es númerico
        /// </summary>
        /// <param name="information"></param>
        /// <returns></returns>
        public static string NumericValidation(string information)
        {
            int convertido;

            while (!int.TryParse(information, out convertido) && string.IsNullOrEmpty(information))
            {
                Console.WriteLine("El dato ingresado debe ser un número. \n Por favor reingrese el dato");
                Console.WriteLine();
                information = Console.ReadLine();
            }
            return information;
        }

        /// <summary>
        /// Valaida si el dato ingresado es una string
        /// </summary>
        /// <param name="information"></param>
        /// <returns></returns>
        public static string StringValidation(string information)
        {
            while (string.IsNullOrEmpty(information))
            {
                Console.WriteLine("Error,reingrese opcion valida.");
                information = Console.ReadLine().ToLower().Trim();
            }
            return information;
        }

        /// <summary>
        /// Valida si el dato ingresado es Si o No 
        /// </summary>
        /// <param name="information"></param>
        /// <returns></returns>
        public static string ValidarSiNo(string information)
        {
            while (string.IsNullOrEmpty(information) || information != "no" && information != "si")
            {
                Console.WriteLine("Por favor ingresar una opción valida");
                information = Console.ReadLine().ToLower().Trim();
            }
            return information;
        }
    }
}