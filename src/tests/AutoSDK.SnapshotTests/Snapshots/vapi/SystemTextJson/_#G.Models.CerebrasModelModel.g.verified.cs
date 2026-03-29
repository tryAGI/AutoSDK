//HintName: G.Models.CerebrasModelModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the name of the model. Ex. cognitivecomputations/dolphin-mixtral-8x7b
    /// </summary>
    public enum CerebrasModelModel
    {
        /// <summary>
        /// 
        /// </summary>
        Llama3370b,
        /// <summary>
        /// 
        /// </summary>
        Llama318b,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CerebrasModelModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CerebrasModelModel value)
        {
            return value switch
            {
                CerebrasModelModel.Llama3370b => "llama-3.3-70b",
                CerebrasModelModel.Llama318b => "llama3.1-8b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CerebrasModelModel? ToEnum(string value)
        {
            return value switch
            {
                "llama-3.3-70b" => CerebrasModelModel.Llama3370b,
                "llama3.1-8b" => CerebrasModelModel.Llama318b,
                _ => null,
            };
        }
    }
}