namespace DNALab
{
    /// <summary>
    ///     The interface for decoding functionality.
    /// </summary>
    /// <typeparam name="TSource">The type of the source data.</typeparam>
    /// <typeparam name="TResult">The type of the result data.</typeparam>
    public interface IDecoder<in TSource, out TResult>
    {
        /// <summary>Decodes the specified value.</summary>
        /// <param name="value">The value.</param>
        TResult Decode(TSource value);
    }
}