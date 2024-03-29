﻿using DNALab.Core;

namespace DNALab;

public static class StringExtensions
{
    /// <summary>
    ///     Determines whether the specified value is DNA sequence.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>
    ///     <c>true</c> if [is AND sequence] otherwise, <c>false</c>.
    /// </returns>
    public static bool IsDNASequence(this string value)
    {
        if (string.IsNullOrEmpty(value) || value.Length % Constants.Nucleotides.Length != 0) return false;

        return value.ToUpperInvariant().All(c => Constants.Nucleotides.Contains(c));
    }

    /// <summary>
    ///     Splits the specified value into chunks of predefined size.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="chunkSize">Size of the chunk.</param>
    /// <returns>IEnumerable sequence of chunks.</returns>
    public static IEnumerable<string> SplitToChunks(this string value, int chunkSize)
    {
        var result = new List<string>();

        if (chunkSize < 1) return result;

        if (chunkSize >= value.Length)
        {
            result.Add(value);
            return result;
        }

        for (var i = 0; i < value.Length; i += chunkSize)
            result.Add(value.Substring(i, Math.Min(chunkSize, value.Length - i)));

        return result;
    }
}
