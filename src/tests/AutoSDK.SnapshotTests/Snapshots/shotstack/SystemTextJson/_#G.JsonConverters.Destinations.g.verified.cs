//HintName: G.JsonConverters.Destinations.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class DestinationsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Destinations>
    {
        /// <inheritdoc />
        public override global::G.Destinations Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("exclude")) __score0++;
            if (__jsonProps.Contains("provider")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("options")) __score1++;
            if (__jsonProps.Contains("provider")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("options")) __score2++;
            if (__jsonProps.Contains("provider")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("options")) __score3++;
            if (__jsonProps.Contains("provider")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("options")) __score4++;
            if (__jsonProps.Contains("provider")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("options")) __score5++;
            if (__jsonProps.Contains("provider")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("options")) __score6++;
            if (__jsonProps.Contains("provider")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("options")) __score7++;
            if (__jsonProps.Contains("provider")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("options")) __score8++;
            if (__jsonProps.Contains("provider")) __score8++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }

            global::G.ShotstackDestination? shotstackDestination = default;
            global::G.MuxDestination? muxDestination = default;
            global::G.S3Destination? s3Destination = default;
            global::G.GoogleCloudStorageDestination? googleCloudStorageDestination = default;
            global::G.GoogleDriveDestination? googleDriveDestination = default;
            global::G.VimeoDestination? vimeoDestination = default;
            global::G.TiktokDestination? tiktokDestination = default;
            global::G.AkamaiNetStorageDestination? akamaiNetStorageDestination = default;
            global::G.AzureBlobStorageDestination? azureBlobStorageDestination = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShotstackDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShotstackDestination> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ShotstackDestination).Name}");
                        shotstackDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MuxDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MuxDestination> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MuxDestination).Name}");
                        muxDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.S3Destination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.S3Destination> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.S3Destination).Name}");
                        s3Destination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoogleCloudStorageDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoogleCloudStorageDestination> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GoogleCloudStorageDestination).Name}");
                        googleCloudStorageDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoogleDriveDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoogleDriveDestination> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GoogleDriveDestination).Name}");
                        googleDriveDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VimeoDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VimeoDestination> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.VimeoDestination).Name}");
                        vimeoDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TiktokDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TiktokDestination> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TiktokDestination).Name}");
                        tiktokDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AkamaiNetStorageDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AkamaiNetStorageDestination> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AkamaiNetStorageDestination).Name}");
                        akamaiNetStorageDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AzureBlobStorageDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AzureBlobStorageDestination> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AzureBlobStorageDestination).Name}");
                        azureBlobStorageDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (shotstackDestination == null && muxDestination == null && s3Destination == null && googleCloudStorageDestination == null && googleDriveDestination == null && vimeoDestination == null && tiktokDestination == null && akamaiNetStorageDestination == null && azureBlobStorageDestination == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShotstackDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShotstackDestination> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ShotstackDestination).Name}");
                    shotstackDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MuxDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MuxDestination> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MuxDestination).Name}");
                    muxDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.S3Destination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.S3Destination> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.S3Destination).Name}");
                    s3Destination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoogleCloudStorageDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoogleCloudStorageDestination> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GoogleCloudStorageDestination).Name}");
                    googleCloudStorageDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoogleDriveDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoogleDriveDestination> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GoogleDriveDestination).Name}");
                    googleDriveDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VimeoDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VimeoDestination> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.VimeoDestination).Name}");
                    vimeoDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TiktokDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TiktokDestination> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TiktokDestination).Name}");
                    tiktokDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AkamaiNetStorageDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AkamaiNetStorageDestination> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AkamaiNetStorageDestination).Name}");
                    akamaiNetStorageDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AzureBlobStorageDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AzureBlobStorageDestination> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AzureBlobStorageDestination).Name}");
                    azureBlobStorageDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.Destinations(
                shotstackDestination,

                muxDestination,

                s3Destination,

                googleCloudStorageDestination,

                googleDriveDestination,

                vimeoDestination,

                tiktokDestination,

                akamaiNetStorageDestination,

                azureBlobStorageDestination
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Destinations value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsShotstackDestination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShotstackDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShotstackDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ShotstackDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShotstackDestination!, typeInfo);
            }
            else if (value.IsMuxDestination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MuxDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MuxDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MuxDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MuxDestination!, typeInfo);
            }
            else if (value.IsS3Destination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.S3Destination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.S3Destination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.S3Destination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.S3Destination!, typeInfo);
            }
            else if (value.IsGoogleCloudStorageDestination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoogleCloudStorageDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoogleCloudStorageDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GoogleCloudStorageDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCloudStorageDestination!, typeInfo);
            }
            else if (value.IsGoogleDriveDestination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoogleDriveDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoogleDriveDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GoogleDriveDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleDriveDestination!, typeInfo);
            }
            else if (value.IsVimeoDestination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VimeoDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VimeoDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.VimeoDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VimeoDestination!, typeInfo);
            }
            else if (value.IsTiktokDestination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TiktokDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TiktokDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TiktokDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TiktokDestination!, typeInfo);
            }
            else if (value.IsAkamaiNetStorageDestination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AkamaiNetStorageDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AkamaiNetStorageDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AkamaiNetStorageDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AkamaiNetStorageDestination!, typeInfo);
            }
            else if (value.IsAzureBlobStorageDestination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AzureBlobStorageDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AzureBlobStorageDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AzureBlobStorageDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureBlobStorageDestination!, typeInfo);
            }
        }
    }
}