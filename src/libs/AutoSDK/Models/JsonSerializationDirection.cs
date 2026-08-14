namespace AutoSDK.Models;

/// <summary>
/// Describes how a generated type is reached from the operation graph:
/// only while serializing requests, only while deserializing responses, or both.
/// Used to pick the narrowest safe <c>JsonSourceGenerationMode</c> for its
/// <c>[JsonSerializable]</c> registration.
/// </summary>
[Flags]
public enum JsonSerializationDirection
{
    /// <summary>
    /// The type is not reachable from any operation, so the direction is unknown.
    /// </summary>
    None = 0,

    /// <summary>
    /// The type is reached through request bodies or parameters only.
    /// </summary>
    Request = 1,

    /// <summary>
    /// The type is reached through response bodies only.
    /// </summary>
    Response = 2,

    /// <summary>
    /// The type is reached in both directions.
    /// </summary>
    Both = Request | Response,
}
