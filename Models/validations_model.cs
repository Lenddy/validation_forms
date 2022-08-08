using System.ComponentModel.DataAnnotations;
namespace validation_model.Models;

public class validation {
    // ! some of this things can be done in the html
    [Required] //* this means that this is required to have
    [MinLength(4,ErrorMessage =" must be at least 4 character")] //* this is the min length that you need to have to pass the validation and has a custom message by using ErrorMessage =
    [Display(Name = "First name")] //* this will display it as First name  insted of F_name by using  Display(Name = "First name")
    public string F_name{get;set;} = null!; 
    [Required()]
    [MinLength(4,ErrorMessage =" must be at least 4 character")]
    [Display(Name = "Last name")]
    public string L_name{get;set;} = null!; 

    [Required]
    [Range(0,Int32.MaxValue,ErrorMessage ="must be a positive number")]
    public int Age{get;set;}

    [Required]
    [DataType(DataType.EmailAddress,ErrorMessage ="does not follows the right format")] //* DataType(DataType.EmailAddress)  this will  make the input have the email format  == lenddy@gmail.com
    public string Email{get;set;} = null!;
    [Required]
    [MinLength(8,ErrorMessage =" must be at least 8 character")]
    [DataType(DataType.Password)] //* this will  hide what the user iputs 
    public string Password{get;set;} = null!;


}