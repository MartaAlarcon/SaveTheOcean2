using SalvaOceano.DTO;
using System.Xml;

namespace SaveTheOcean2
{
    public static class XMLHelpers
    {
        public static void CreateXMLFile(Player player, string filePath)
        {
            if (File.Exists(filePath))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);


                // Verificar si el jugador ya existe en el archivo XML
                if (PlayerExists(xmlDoc, player))
                {
                    Console.WriteLine($"El jugador {player.Name} con el rol {player.Rol} ya existe en el archivo XML. No se agregará.");
                    return;
                }
            }
            else
            {
                File.Create(filePath).Close();
            }

            // Si el archivo no existe o el jugador no existe, crear o agregar el jugador
            AddPlayerToXML(player, filePath);
        }

        private static bool PlayerExists(XmlDocument xmlDoc, Player player)
        {
            // Buscar todos los nodos de jugador en el documento XML
            XmlNodeList playerNodes = xmlDoc.SelectNodes("//Player");

            // Iterar sobre cada nodo de jugador
            foreach (XmlNode playerNode in playerNodes)
            {
                // Obtener el nombre y el rol del jugador existente
                string playerName = playerNode.SelectSingleNode("Name").InnerText;
                string playerRol = playerNode.SelectSingleNode("Rol").InnerText;


                // Verificar si el nombre y el rol del jugador existente coinciden con el jugador actual
                if (playerName == player.Name && playerRol == player.Rol)
                {
                    playerNode.SelectSingleNode("Jugando").InnerText = "true";
                    xmlDoc.Save("player.xml");
                    return true; // El jugador ya existe en el archivo XML
                }
            }

            return false; // El jugador no existe en el archivo XML
        }

            private static void AddPlayerToXML(Player player, string filePath)
            {
                // Crear un nuevo documento XML si el archivo no existe
                if (!File.Exists(filePath))
                {
                    XmlDocument xmlDoc = new XmlDocument();

                    // Crear el elemento raíz
                    XmlElement playersElement = xmlDoc.CreateElement("PlayersList");
                    xmlDoc.AppendChild(playersElement);

                    // Agregar el jugador como un nodo al elemento raíz
                    AddPlayerNode(xmlDoc, playersElement, player);

                    // Guardar el documento XML en el archivo especificado
                    xmlDoc.Save(filePath);

                    Console.WriteLine("Documento XML creado correctamente.");
                }
                else
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(filePath);

                    // Obtener el elemento raíz
                    XmlElement playersElement = xmlDoc.DocumentElement;

                    // Agregar el jugador como un nodo al elemento raíz
                    AddPlayerNode(xmlDoc, playersElement, player);

                    // Guardar el documento XML en el archivo especificado
                    xmlDoc.Save(filePath);

                    Console.WriteLine("Jugador agregado al documento XML existente.");
                }
            }

            private static void AddPlayerNode(XmlDocument xmlDoc, XmlElement parentElement, Player player)
            {
                // Crear el nodo para el jugador
                XmlElement playerElement = xmlDoc.CreateElement("Player");
                parentElement.AppendChild(playerElement);

                // Agregar los elementos hijos al nodo del jugador
                AddChildElement(xmlDoc, playerElement, "Name", player.Name);
                AddChildElement(xmlDoc, playerElement, "Rol", player.Rol);
                AddChildElement(xmlDoc, playerElement, "Xp", player.Xp.ToString());
                AddChildElement(xmlDoc, playerElement, "Jugando", player.Play.ToString());
     
        

        }

        private static void AddChildElement(XmlDocument xmlDoc, XmlElement parentElement, string elementName, string value)
        {
            // Crear el elemento hijo
            XmlElement childElement = xmlDoc.CreateElement(elementName);
            childElement.InnerText = value;
            parentElement.AppendChild(childElement);
        }
        
        public static void AddFalsePlay()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("player.xml");
            XmlNodeList playerNodes = xmlDoc.SelectNodes("//Player");
            foreach (XmlNode playerNode in playerNodes)
            {
                playerNode.SelectSingleNode("Jugando").InnerText = "false";
            }
            xmlDoc.Save("player.xml");
        }

        public static void AddXp(int value)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("player.xml");
            XmlNodeList playerNodes = xmlDoc.SelectNodes("//Player[Jugando='true']");
            foreach (XmlNode playerNode in playerNodes)
            {

                string playerName = playerNode.SelectSingleNode("Name").InnerText;
                int currentXp = int.Parse(playerNode.SelectSingleNode("Xp").InnerText);
                int newXp = currentXp + value;
                playerNode.SelectSingleNode("Xp").InnerText = newXp.ToString();
                MessageBox.Show($"Has guanyat {value} punts d'experiència. El teu total de punts d'experiència és: {newXp}");
            }
            
            xmlDoc.Save("player.xml");
        }

        // Método para obtener el jugador actualmente jugando
        public static Player GetCurrentPlayer()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("player.xml");
            XmlNodeList playerNodes = xmlDoc.SelectNodes("//Player[Jugando='true']");
            foreach (XmlNode playerNode in playerNodes)
            {
                Player currentPlayer = new Player
                {
                    Name = playerNode.SelectSingleNode("Name").InnerText,
                    Rol = playerNode.SelectSingleNode("Rol").InnerText,
                    Xp = int.Parse(playerNode.SelectSingleNode("Xp").InnerText),
                    Play = true
                };
                return currentPlayer;
            }
            return null;
        }
        public static string GetPlayerName()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("player.xml");
            XmlNodeList playerNodes = xmlDoc.SelectNodes("//Player");
            foreach (XmlNode playerNode in playerNodes)
            {
                if (playerNode.SelectSingleNode("Jugando").InnerText == "true")
                {
                    return playerNode.SelectSingleNode("Name").InnerText;
                }
            }
            return null;
        }
    }
}
