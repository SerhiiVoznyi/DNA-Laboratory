namespace DNALab.Concurrent
{
    using System.Threading.Tasks;

    /// <summary>
    ///     The interface for concurrent encoding functionality.
    /// </summary>
    /// <typeparam name="TSource">The type of the source.</typeparam>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    public interface IEncoder<in TSource, TResult>
    {
        /// <summary>
        ///     Encodes the value asynchronously.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Task of encoding result.</returns>
        Task<TResult> EncodeAsync(TSource value);
    }
}