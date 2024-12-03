//HintName: G.Models.ReposListActivitiesDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ReposListActivitiesDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposListActivitiesDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposListActivitiesDirection value)
        {
            return value switch
            {
                ReposListActivitiesDirection.Asc => "asc",
                ReposListActivitiesDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListActivitiesDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ReposListActivitiesDirection.Asc,
                "desc" => ReposListActivitiesDirection.Desc,
                _ => null,
            };
        }
    }
}