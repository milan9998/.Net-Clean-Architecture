namespace USP.Application.Common.Exceptions;

public class UspValidationException (IDictionary<string, string[]> failures) : BaseException("One ore more validations failed",failures);


    
    
            
    
  
