using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Unitilies.Results
{
    //Service da List olarak dönen metotlarımız icin oluşturduk.
    //IDataResult da IResult gibi içinde mesaj ve işlem sonucu içersin aynı zamanda data içersin istiyoruz.
    //mesaj ve işlem sonucu IResult da olduğu icin ondan kalıtım alıyoruz.
    public interface IDataResult<T>:IResult
    {
        //Extradan icinde  T tipinde data larda olucak.
        T Data { get; }
    }
}
