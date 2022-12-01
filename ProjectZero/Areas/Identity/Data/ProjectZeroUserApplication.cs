using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProjectZero.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ProjectZeroUserApplication class
public class ProjectZeroUserApplication : IdentityUser
{
    [Key]
    public int uid { get; set; }

    [PersonalData]
    [Column(TypeName = "varchar(100)")]
    public string firstName { get; set; }

    
    [PersonalData]
    [Column(TypeName = "varchar(100)")]
    public string lastName { get; set; }
}

