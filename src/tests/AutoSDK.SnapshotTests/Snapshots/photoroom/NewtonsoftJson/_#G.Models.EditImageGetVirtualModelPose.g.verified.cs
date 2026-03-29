//HintName: G.Models.EditImageGetVirtualModelPose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: random
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EditImageGetVirtualModelPose
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="34turn")]
        x34turn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="adjustingclothing")]
        Adjustingclothing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="back")]
        Back,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="crossedarms")]
        Crossedarms,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="handinpocket")]
        Handinpocket,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="overtheshoulder")]
        Overtheshoulder,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="playfulspin")]
        Playfulspin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="powerstance")]
        Powerstance,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="random")]
        Random,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="seated")]
        Seated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="standing")]
        Standing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="walkingforward")]
        Walkingforward,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetVirtualModelPoseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetVirtualModelPose value)
        {
            return value switch
            {
                EditImageGetVirtualModelPose.x34turn => "34turn",
                EditImageGetVirtualModelPose.Adjustingclothing => "adjustingclothing",
                EditImageGetVirtualModelPose.Back => "back",
                EditImageGetVirtualModelPose.Crossedarms => "crossedarms",
                EditImageGetVirtualModelPose.Handinpocket => "handinpocket",
                EditImageGetVirtualModelPose.Overtheshoulder => "overtheshoulder",
                EditImageGetVirtualModelPose.Playfulspin => "playfulspin",
                EditImageGetVirtualModelPose.Powerstance => "powerstance",
                EditImageGetVirtualModelPose.Random => "random",
                EditImageGetVirtualModelPose.Seated => "seated",
                EditImageGetVirtualModelPose.Standing => "standing",
                EditImageGetVirtualModelPose.Walkingforward => "walkingforward",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetVirtualModelPose? ToEnum(string value)
        {
            return value switch
            {
                "34turn" => EditImageGetVirtualModelPose.x34turn,
                "adjustingclothing" => EditImageGetVirtualModelPose.Adjustingclothing,
                "back" => EditImageGetVirtualModelPose.Back,
                "crossedarms" => EditImageGetVirtualModelPose.Crossedarms,
                "handinpocket" => EditImageGetVirtualModelPose.Handinpocket,
                "overtheshoulder" => EditImageGetVirtualModelPose.Overtheshoulder,
                "playfulspin" => EditImageGetVirtualModelPose.Playfulspin,
                "powerstance" => EditImageGetVirtualModelPose.Powerstance,
                "random" => EditImageGetVirtualModelPose.Random,
                "seated" => EditImageGetVirtualModelPose.Seated,
                "standing" => EditImageGetVirtualModelPose.Standing,
                "walkingforward" => EditImageGetVirtualModelPose.Walkingforward,
                _ => null,
            };
        }
    }
}