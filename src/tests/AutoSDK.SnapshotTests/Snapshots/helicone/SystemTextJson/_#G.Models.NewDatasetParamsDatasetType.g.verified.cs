//HintName: G.Models.NewDatasetParamsDatasetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum NewDatasetParamsDatasetType
    {
        /// <summary>
        /// 
        /// </summary>
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        Helicone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NewDatasetParamsDatasetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewDatasetParamsDatasetType value)
        {
            return value switch
            {
                NewDatasetParamsDatasetType.Experiment => "experiment",
                NewDatasetParamsDatasetType.Helicone => "helicone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewDatasetParamsDatasetType? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => NewDatasetParamsDatasetType.Experiment,
                "helicone" => NewDatasetParamsDatasetType.Helicone,
                _ => null,
            };
        }
    }
}