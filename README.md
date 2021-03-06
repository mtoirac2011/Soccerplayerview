# **A Back-End Code-Louisville Project**
##### Version 1.0

## Welcome to the official repository of Soccer player view!

The soccer players view pretents to give you a brief view about some of the best soccer players. It is a console application Back-End CodeLouisville project, where each student reinforces what we have learned and show off our skills. This project will be part of our go-to tool to show off to potential employers and demonstrate we know what we are talking about.

### *Features included in the project:*
* ###### Implement a“master loop" console application (Program class).
* ###### Create an additional class which inherits one or more properties from its parent (Player class).
* ###### Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program (Quote class).
* ###### Implement a log that records errors (**Soccerlog.txt** records wrong login, error converting data, players loaded from CSV file, and player manually added/deleted).
* ###### Read data from an external file, such as text, JSON, CSV (**Soccerplayers.csv** is used for loading players to the application. **Soccerplayersallstar.json** is used on Report menu to list soccer leyends).
* ###### Implement a regular expression (**regex**) (used on **Welcome** screen validating email format).
```
Regex emailFormat = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"); 
```
* ###### Use a LINQ query to retrieve information from a data structure (used on Report menu listing soccer players ordered by name).
* ###### Create 3 or more unit tests for your application (used on Converter class).
```
public void ConverterTest()
        {
            string x = "72";
            var value = new Converter(x);
            Assert.Equal(x, value.X);
        }
```
* ###### Build a conversion tool that converts user input to another type and displays it (used on Converter menu converting the input into: Fahrenheit to celsius, Miles to kilometers, Feet to meters, and Meters to centimeters).
* ###### Calculate and display data based on an external factor (used to have the age of the soccer players in Report menu).
```
age = DateTime.Now.Year - player.Dob.Year;
if (DateTime.Now.DayOfYear < player.Dob.DayOfYear)
   age = age - 1;
```
* ###### Analyze text and display information about it (used on Quote menu searching an string in the quote, first char,  last char, upper/lower case the quote, and spaces deleted).

### This project is made up of the following menus:

### **Welcome** (Login with email)

### **Main Menu** 

* #### **Player Menu** 
 * ##### **Add new Player**  
   * ###### *Load players from CSV file*
   * ###### *Add player manually*
 * ##### **Delete a Player**

* #### **Soccer quotes Menu**
  * ###### *Check if string exists in the quote*
  * ###### *Other features of selected quote*
  * ###### *Switch to other quote*

* #### **Report Menu** 
  * ###### *List players*
  * ###### *Best soccer star leyends*
  * ###### *Best soccer star leyends (Order by Name)*
  * ###### *List soccer quotes*

* #### **Converter Menu** (Convert an input value to:)
  * ###### *Fahrenheit to celsius*
  * ###### *Miles to kilometers*
  * ###### *Feet to meters*
  * ###### *Meters to centimeters*

* #### **Exit**

### A brief Menu description 
### Welcome window
It welcomes the application and permits you to log in the application.
###### (located in Util.cs)

### Main Menu
It allows you access to the other menus.
###### (located in Menu.cs)

### Player Menu
In this menu we can add and delete players. We can add player manually and loading player from a CVS file. 
We also are able to delete players. We work with flexible menu depending of if we have loaded players from the csv file.
###### (located in Player.cs)

### Soccer quotes Menu
We use a list of soccer quotes and work and apply some string method to the selected socccer quote. 
###### (located in Quote.cs)

### Reporting Menu
In this menu we are able to print to the console the list of player, the soccer quotes, and the list of soccer leyends using a format for output.
###### (located in Report.cs)

### Converter Menu
 It converts an input into Fahrenheit to celsius, Miles to kilometers, Feet to meters, and Meters to centimeters.
###### (located in Converter.cs)