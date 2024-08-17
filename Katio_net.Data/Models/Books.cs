namespace Katio.Data.Models;

public class Books{

public int Id {get; set;}
public String Title {get; set;} = "";
public String ISBN10 {get; set;} = "";
public String ISBN13 {get; set;} = "";
public DateTime Published {get; set;}
public String Edition {get; set;} = "";
public String DeweyIndex {get; set;} = "";

}
