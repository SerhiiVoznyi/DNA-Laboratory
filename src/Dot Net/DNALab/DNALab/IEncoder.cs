namespace DNALab
{
    /// <summary>
    ///     The interface for encoding functionality.
    /// </summary>
    /// <typeparam name="TSource">The type of the source.</typeparam>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    public interface IEncoder<in TSource, out TResult>
    {
        /// <summary>
        ///     Encodes the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        TResult Encode(TSource value);
    }
}