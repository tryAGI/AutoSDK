//HintName: G.Models.AnyscaleModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnyscaleModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Anyscale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnyscaleModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnyscaleModelProvider value)
        {
            return value switch
            {
                AnyscaleModelProvider.Anyscale => "anyscale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnyscaleModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "anyscale" => AnyscaleModelProvider.Anyscale,
                _ => null,
            };
        }
    }
}