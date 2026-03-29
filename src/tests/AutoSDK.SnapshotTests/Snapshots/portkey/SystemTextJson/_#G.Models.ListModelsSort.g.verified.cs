//HintName: G.Models.ListModelsSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: name
    /// </summary>
    public enum ListModelsSort
    {
        /// <summary>
        /// 
        /// </summary>
        AiService,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Provider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListModelsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListModelsSort value)
        {
            return value switch
            {
                ListModelsSort.AiService => "ai_service",
                ListModelsSort.Name => "name",
                ListModelsSort.Provider => "provider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListModelsSort? ToEnum(string value)
        {
            return value switch
            {
                "ai_service" => ListModelsSort.AiService,
                "name" => ListModelsSort.Name,
                "provider" => ListModelsSort.Provider,
                _ => null,
            };
        }
    }
}