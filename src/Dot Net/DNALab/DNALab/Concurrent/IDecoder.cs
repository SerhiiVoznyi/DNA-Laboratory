namespace DNALab.Concurrent
{
    using System.Threading.Tasks;

    /// <summary>
    ///     The interface for concurrent decoding functionality.
    /// </summary>
    /// <typeparam name="TSource">The type of the source.</typeparam>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    public interface IDecoder<in TSource, TResult>
    {
        /// <summary>
        ///     Decodes the value asynchronously.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        Task<TResult> DecodeAsync(TSource value);
    }
}