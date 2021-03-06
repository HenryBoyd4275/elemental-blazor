﻿using Elemental.Components.FormsInternal;
using System;
using System.ComponentModel.DataAnnotations;

namespace ElementalDocs.Data
{
    public class Starship
    {
        [Required]
        [StringLength(16, ErrorMessage = "Identifier too long (16 character limit).")]
        public string Identifier { get; set; }

        public string Description { get; set; }

        [Required]
        public string Classification { get; set; }

        [Range(1, 100000, ErrorMessage = "Accommodation invalid (1-100000).")]
        [AeLabelAttribute("Maximum Accomodation")]
        public int MaximumAccommodation { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true", ErrorMessage = "This form disallows unapproved ships.")]
        [AeLabelAttribute("Validated Design")]
        public bool IsValidatedDesign { get; set; }

        [Required]
        [AeLabelAttribute("Production Date")]
        public DateTime ProductionDate { get; set; }
    }
}
