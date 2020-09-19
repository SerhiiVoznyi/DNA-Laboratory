namespace DNALab.Core
{
    using System;

    /// <summary>
    ///     The class representation of invalid DNA sequence exception.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class InvalidDNASequenceException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="InvalidDNASequenceException" /> class.
        /// </summary>
        public InvalidDNASequenceException()
            : base(
                $"A DNA sequence should contain only '{Constants.Adenine}', '{Constants.Guanine}', '{Constants.Cytosine}', and '{Constants.Thymine}', and length of it should multiple of four.")
        {
        }
    }
}