# A Back-End Code-Louisville Project.
##### Version 1.0

## Welcome to the official repository of Soccer player view!

The soccer player view, is a console application Back-End CodeLouisville project, where each student reinforces what we have learned and show off our skills. These projects will be part of our go-to tool to show off to potential employers and demonstrate we know what we’re talking about.

### The soccer is here pretents to give you a brief view about some of the best soccer players, and this project is made up of the following menus:

### **Welcome** (Login with email)
```
Regex emailFormat = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"); 
```
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

### Main Menu
It welcomes the application and allows you access to the other menus.
###### (located in Menu.css)

### Player Menu
In this menu we can add and delete players. We can add player manually and loading player from a CVS file. 
We also are able to delete players. We work with flexible menu depending of if we have loaded players from the csv file.
###### (located in Menu.css)

### Soccer quotes Menu
We use a list of soccer quotes and work and apply some string method to the selected socccer quote. 
###### (located in Menu.css)

### Reporting Menu
In this menu we are able to print to the console both, the list of player and the soccer quotes.
###### (located in Menu.css)