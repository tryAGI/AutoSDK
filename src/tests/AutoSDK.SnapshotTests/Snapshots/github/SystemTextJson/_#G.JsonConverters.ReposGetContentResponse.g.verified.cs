//HintName: G.JsonConverters.ReposGetContentResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ReposGetContentResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReposGetContentResponse>
    {
        /// <inheritdoc />
        public override global::G.ReposGetContentResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

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
            var __score1 = 0;
            if (__jsonProps.Contains("_links")) __score1++;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("download_url")) __score1++;
            if (__jsonProps.Contains("encoding")) __score1++;
            if (__jsonProps.Contains("git_url")) __score1++;
            if (__jsonProps.Contains("html_url")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("path")) __score1++;
            if (__jsonProps.Contains("sha")) __score1++;
            if (__jsonProps.Contains("size")) __score1++;
            if (__jsonProps.Contains("submodule_git_url")) __score1++;
            if (__jsonProps.Contains("target")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("url")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("_links")) __score2++;
            if (__jsonProps.Contains("download_url")) __score2++;
            if (__jsonProps.Contains("git_url")) __score2++;
            if (__jsonProps.Contains("html_url")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("path")) __score2++;
            if (__jsonProps.Contains("sha")) __score2++;
            if (__jsonProps.Contains("size")) __score2++;
            if (__jsonProps.Contains("target")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("url")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("_links")) __score3++;
            if (__jsonProps.Contains("download_url")) __score3++;
            if (__jsonProps.Contains("git_url")) __score3++;
            if (__jsonProps.Contains("html_url")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("path")) __score3++;
            if (__jsonProps.Contains("sha")) __score3++;
            if (__jsonProps.Contains("size")) __score3++;
            if (__jsonProps.Contains("submodule_git_url")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("url")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>? contentDirectory = default;
            global::G.ContentFile? file = default;
            global::G.ContentSymlink? symlink = default;
            global::G.ContentSubmodule? submodule = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        contentDirectory = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>>(__rawJson, options);
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
                        file = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ContentFile>(__rawJson, options);
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
                        symlink = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ContentSymlink>(__rawJson, options);
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
                        submodule = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ContentSubmodule>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (contentDirectory == null && file == null && symlink == null && submodule == null)
            {
                try
                {
                    contentDirectory = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    file = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ContentFile>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    symlink = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ContentSymlink>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    submodule = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ContentSubmodule>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ReposGetContentResponse(
                contentDirectory,

                file,

                symlink,

                submodule
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReposGetContentResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsContentDirectory)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentDirectory, typeof(global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>), options);
            }
            else if (value.IsFile)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File, typeof(global::G.ContentFile), options);
            }
            else if (value.IsSymlink)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Symlink, typeof(global::G.ContentSymlink), options);
            }
            else if (value.IsSubmodule)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Submodule, typeof(global::G.ContentSubmodule), options);
            }
        }
    }
}