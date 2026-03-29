//HintName: G.Models.GraphType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of Knowledge Graph:<br/>
    /// - `manual`: files are uploaded via UI or API<br/>
    /// - `connector`: files are uploaded via a data connector such as Google Drive or Confluence<br/>
    /// - `web`: URLs are connected to the Knowledge Graph
    /// </summary>
    public enum GraphType
    {
        /// <summary>
        /// files are uploaded via a data connector such as Google Drive or Confluence
        /// </summary>
        Connector,
        /// <summary>
        /// files are uploaded via UI or API
        /// </summary>
        Manual,
        /// <summary>
        /// URLs are connected to the Knowledge Graph
        /// </summary>
        Web,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraphTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraphType value)
        {
            return value switch
            {
                GraphType.Connector => "connector",
                GraphType.Manual => "manual",
                GraphType.Web => "web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraphType? ToEnum(string value)
        {
            return value switch
            {
                "connector" => GraphType.Connector,
                "manual" => GraphType.Manual,
                "web" => GraphType.Web,
                _ => null,
            };
        }
    }
}