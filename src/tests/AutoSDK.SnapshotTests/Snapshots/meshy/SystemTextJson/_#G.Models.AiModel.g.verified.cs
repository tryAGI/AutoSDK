//HintName: G.Models.AiModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: latest
    /// </summary>
    public enum AiModel
    {
        /// <summary>
        /// 
        /// </summary>
        Latest,
        /// <summary>
        /// 
        /// </summary>
        Meshy5,
        /// <summary>
        /// 
        /// </summary>
        Meshy6,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiModel value)
        {
            return value switch
            {
                AiModel.Latest => "latest",
                AiModel.Meshy5 => "meshy-5",
                AiModel.Meshy6 => "meshy-6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiModel? ToEnum(string value)
        {
            return value switch
            {
                "latest" => AiModel.Latest,
                "meshy-5" => AiModel.Meshy5,
                "meshy-6" => AiModel.Meshy6,
                _ => null,
            };
        }
    }
}