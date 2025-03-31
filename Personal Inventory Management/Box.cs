namespace Personal_Inventory_Management;
public class Box {
    public string Name { get; set; } // box name
    public List<Tuple<string,Boolean,string?,int?>>? items {get; set;} // list of items in the box as well as a boolean (true or false) value for whether it is taken out or not. Each is a tuple so it will work something like this "[item:true,item:false,item:true] etc
    /* Box object constructor */
    public Box(string Name, List<Tuple<string,Boolean, string?,int?>>? items) {
            this.Name = Name;
            this.items = items ?? new List<Tuple<string,Boolean,string?,int?>>(); // question marks mean the list is nullable as a box can have no items in it
    }
}