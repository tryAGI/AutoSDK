//HintName: G.Models.UpdateMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines the mode of the upsert operation<br/>
    /// * `upsert` - default mode, insert new points, update existing points * `insert_only` - only insert new points, do not update existing points * `update_only` - only update existing points, do not insert new points
    /// </summary>
    public enum UpdateMode
    {
        /// <summary>
        /// 
        /// </summary>
        InsertOnly,
        /// <summary>
        /// 
        /// </summary>
        UpdateOnly,
        /// <summary>
        /// 
        /// </summary>
        Upsert,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMode value)
        {
            return value switch
            {
                UpdateMode.InsertOnly => "insert_only",
                UpdateMode.UpdateOnly => "update_only",
                UpdateMode.Upsert => "upsert",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMode? ToEnum(string value)
        {
            return value switch
            {
                "insert_only" => UpdateMode.InsertOnly,
                "update_only" => UpdateMode.UpdateOnly,
                "upsert" => UpdateMode.Upsert,
                _ => null,
            };
        }
    }
}