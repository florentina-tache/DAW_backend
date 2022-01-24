using System;

namespace DAW_Store.Models.Base
{
    public interface IBaseEntity
    {
        Guid Id { get; set; } //Guid e specific .net care e un string (de ex "13s515cd31") cu numere, cifre si e ceva unic
        DateTime? DateCreated { get; set; } //vrem ca data asta sa poatas a fie null asa ca punem "?" 
        DateTime? DateModified { get; set; } //vrem ca data asta sa poatas a fie null asa ca punem "?" 
    }
}