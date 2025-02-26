//HintName: G.Models.ModelVariant4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Our most intelligent model
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-5-sonnet-latest")]
        Claude35SonnetLatest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant4 value)
        {
            return value switch
            {
                ModelVariant4.Claude35SonnetLatest => "claude-3-5-sonnet-latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant4? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-5-sonnet-latest" => ModelVariant4.Claude35SonnetLatest,
                _ => null,
            };
        }
    }
}