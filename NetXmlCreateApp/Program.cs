using ExampleClassLibrary;
using System.Xml;

User user  = new User();
user.Name = "Leo";
user.Age = 30;
user.Address = new Address();
user.Address.City = "Tula";
user.Address.Street = "Oboronnaya";

XmlDocument document = new XmlDocument();
document.Load("myusers.xml");

XmlElement? root = document.DocumentElement;

/*
XmlElement city = document.CreateElement("City");
city.InnerText = user.Address.City;

XmlElement street = document.CreateElement("Street");
XmlText streetText = document.CreateTextNode(user.Address.Street);
street.AppendChild(streetText);

XmlElement address = document.CreateElement("Address");
address.AppendChild(city);
address.AppendChild(street);

XmlElement name = document.CreateElement("Name");
name.InnerText = user.Name;

XmlElement age = document.CreateElement("Age");
age.InnerText = user.Age.ToString();

XmlElement userXml = document.CreateElement("User");
userXml.AppendChild(name);
userXml.AppendChild(age);
userXml.AppendChild(address);

XmlAttribute role = document.CreateAttribute("role");
role.Value = "member";

userXml.Attributes.Append(role);

root?.AppendChild(userXml);
*/


XmlNode? node = root?.FirstChild;
root?.RemoveChild(node!);

document.Save("myusers.xml");
