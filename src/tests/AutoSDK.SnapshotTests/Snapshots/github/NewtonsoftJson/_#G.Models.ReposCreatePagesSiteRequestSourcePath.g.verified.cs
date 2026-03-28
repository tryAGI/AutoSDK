//HintName: G.Models.ReposCreatePagesSiteRequestSourcePath.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The repository directory that includes the source files for the Pages site. Allowed paths are `/` or `/docs`. Default: `/`<br/>
    /// Default Value: /
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposCreatePagesSiteRequestSourcePath
    {
        /// <summary>
        /// `/`
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="/")]
        Divide,
        /// <summary>
        /// `/`
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="/docs")]
        Dividedocs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposCreatePagesSiteRequestSourcePathExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposCreatePagesSiteRequestSourcePath value)
        {
            return value switch
            {
                ReposCreatePagesSiteRequestSourcePath.Divide => "/",
                ReposCreatePagesSiteRequestSourcePath.Dividedocs => "/docs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreatePagesSiteRequestSourcePath? ToEnum(string value)
        {
            return value switch
            {
                "/" => ReposCreatePagesSiteRequestSourcePath.Divide,
                "/docs" => ReposCreatePagesSiteRequestSourcePath.Dividedocs,
                _ => null,
            };
        }
    }
}