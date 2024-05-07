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
                // Si el archivo no existe, crearlo con la estructura inicial
                CreateInitialXMLFile(filePath);
            }

            // Si el archivo no existe o el jugador no existe, crear o agregar el jugador
            AddPlayerToXML(player, filePath);
        }

        private static void CreateInitialXMLFile(string filePath)
        {
            try
            {
                // Crear el documento XML con la estructura inicial
                XmlDocument xmlDoc = new XmlDocument();
                XmlElement playersListElement = xmlDoc.CreateElement("PlayersList");
                xmlDoc.AppendChild(playersListElement);
                xmlDoc.Save(filePath);
                Console.WriteLine("Archivo XML creado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear el archivo XML: {ex.Message}");
            }
        }

        private static bool PlayerExists(XmlDocument xmlDoc, Player player)
        {
            XmlNodeList playerNodes = xmlDoc.SelectNodes("//Player");

            foreach (XmlNode playerNode in playerNodes)
            {
                string playerName = playerNode.SelectSingleNode("Name").InnerText;
                string playerRol = playerNode.SelectSingleNode("Rol").InnerText;

                if (playerName == player.Name && playerRol == player.Rol)
                {
                    playerNode.SelectSingleNode("Jugando").InnerText = "true";
                    xmlDoc.Save("player.xml");
                    return true;
                }
            }

            return false;
        }

        private static void AddPlayerToXML(Player player, string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            XmlElement playersListElement = xmlDoc.DocumentElement;
            AddPlayerNode(xmlDoc, playersListElement, player);

            xmlDoc.Save(filePath);
            Console.WriteLine("Jugador agregado al documento XML existente.");
        }

        private static void AddPlayerNode(XmlDocument xmlDoc, XmlElement parentElement, Player player)
        {
            XmlElement playerElement = xmlDoc.CreateElement("Player");
            parentElement.AppendChild(playerElement);

            AddChildElement(xmlDoc, playerElement, "Name", player.Name);
            AddChildElement(xmlDoc, playerElement, "Rol", player.Rol);
            AddChildElement(xmlDoc, playerElement, "Xp", player.Xp.ToString());
            AddChildElement(xmlDoc, playerElement, "Jugando", player.Play.ToString());
        }

        private static void AddChildElement(XmlDocument xmlDoc, XmlElement parentElement, string elementName, string value)
        {
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

        public static void AddXp(int value, string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            XmlNodeList playerNodes = xmlDoc.SelectNodes("//Player[Jugando='true']");
            foreach (XmlNode playerNode in playerNodes)
            {
                string playerName = playerNode.SelectSingleNode("Name").InnerText;
                int currentXp = int.Parse(playerNode.SelectSingleNode("Xp").InnerText);
                int newXp = currentXp + value;
                playerNode.SelectSingleNode("Xp").InnerText = newXp.ToString();
                MessageBox.Show($"Has ganado {value} puntos de experiencia. Tu total de puntos de experiencia es: {newXp}");
            }

            xmlDoc.Save(filePath);
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