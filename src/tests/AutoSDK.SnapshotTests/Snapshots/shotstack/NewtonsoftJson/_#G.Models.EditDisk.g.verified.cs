//HintName: G.Models.EditDisk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Notice: This option is now deprecated and will be removed. Disk types are handled automatically. Setting a disk type has no effect.**<br/>
    /// The disk type to use for storing footage and assets for each render. See [disk types](https://shotstack.io/docs/guide/architecting-an-application/disk-types/) for more details.<br/>
    /// &lt;ul&gt;<br/>
    ///   &lt;li&gt;`local` - optimized for high speed rendering with up to 512MB storage&lt;/li&gt;<br/>
    ///   &lt;li&gt;`mount` - optimized for larger file sizes and longer videos with 5GB for source footage and 512MB for output render&lt;/li&gt;<br/>
    /// &lt;/ul&gt;
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EditDisk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="local")]
        Local,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mount")]
        Mount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditDiskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditDisk value)
        {
            return value switch
            {
                EditDisk.Local => "local",
                EditDisk.Mount => "mount",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditDisk? ToEnum(string value)
        {
            return value switch
            {
                "local" => EditDisk.Local,
                "mount" => EditDisk.Mount,
                _ => null,
            };
        }
    }
}