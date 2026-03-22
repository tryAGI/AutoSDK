//HintName: G.Models.ConversationInitiationSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum representing the possible sources for conversation initiation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationInitiationSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="android_sdk")]
        AndroidSdk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="flutter_sdk")]
        FlutterSdk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="genesys")]
        Genesys,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="js_sdk")]
        JsSdk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="node_js_sdk")]
        NodeJsSdk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="python_sdk")]
        PythonSdk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="react_native_sdk")]
        ReactNativeSdk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="react_sdk")]
        ReactSdk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sip_trunk")]
        SipTrunk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slack_integration")]
        SlackIntegration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="swift_sdk")]
        SwiftSdk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="template_preview")]
        TemplatePreview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="twilio")]
        Twilio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="whatsapp")]
        Whatsapp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="widget")]
        Widget,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zendesk_integration")]
        ZendeskIntegration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationInitiationSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationInitiationSource value)
        {
            return value switch
            {
                ConversationInitiationSource.AndroidSdk => "android_sdk",
                ConversationInitiationSource.FlutterSdk => "flutter_sdk",
                ConversationInitiationSource.Genesys => "genesys",
                ConversationInitiationSource.JsSdk => "js_sdk",
                ConversationInitiationSource.NodeJsSdk => "node_js_sdk",
                ConversationInitiationSource.PythonSdk => "python_sdk",
                ConversationInitiationSource.ReactNativeSdk => "react_native_sdk",
                ConversationInitiationSource.ReactSdk => "react_sdk",
                ConversationInitiationSource.SipTrunk => "sip_trunk",
                ConversationInitiationSource.SlackIntegration => "slack_integration",
                ConversationInitiationSource.SwiftSdk => "swift_sdk",
                ConversationInitiationSource.TemplatePreview => "template_preview",
                ConversationInitiationSource.Twilio => "twilio",
                ConversationInitiationSource.Unknown => "unknown",
                ConversationInitiationSource.Whatsapp => "whatsapp",
                ConversationInitiationSource.Widget => "widget",
                ConversationInitiationSource.ZendeskIntegration => "zendesk_integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationInitiationSource? ToEnum(string value)
        {
            return value switch
            {
                "android_sdk" => ConversationInitiationSource.AndroidSdk,
                "flutter_sdk" => ConversationInitiationSource.FlutterSdk,
                "genesys" => ConversationInitiationSource.Genesys,
                "js_sdk" => ConversationInitiationSource.JsSdk,
                "node_js_sdk" => ConversationInitiationSource.NodeJsSdk,
                "python_sdk" => ConversationInitiationSource.PythonSdk,
                "react_native_sdk" => ConversationInitiationSource.ReactNativeSdk,
                "react_sdk" => ConversationInitiationSource.ReactSdk,
                "sip_trunk" => ConversationInitiationSource.SipTrunk,
                "slack_integration" => ConversationInitiationSource.SlackIntegration,
                "swift_sdk" => ConversationInitiationSource.SwiftSdk,
                "template_preview" => ConversationInitiationSource.TemplatePreview,
                "twilio" => ConversationInitiationSource.Twilio,
                "unknown" => ConversationInitiationSource.Unknown,
                "whatsapp" => ConversationInitiationSource.Whatsapp,
                "widget" => ConversationInitiationSource.Widget,
                "zendesk_integration" => ConversationInitiationSource.ZendeskIntegration,
                _ => null,
            };
        }
    }
}