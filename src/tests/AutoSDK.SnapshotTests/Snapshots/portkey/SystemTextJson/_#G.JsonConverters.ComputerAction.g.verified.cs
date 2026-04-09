//HintName: G.JsonConverters.ComputerAction.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ComputerActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ComputerAction>
    {
        /// <inheritdoc />
        public override global::G.ComputerAction Read(
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
            if (__jsonProps.Contains("button")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("x")) __score0++;
            if (__jsonProps.Contains("y")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("x")) __score1++;
            if (__jsonProps.Contains("y")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("path")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("keys")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("x")) __score4++;
            if (__jsonProps.Contains("y")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("scroll_x")) __score6++;
            if (__jsonProps.Contains("scroll_y")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            if (__jsonProps.Contains("x")) __score6++;
            if (__jsonProps.Contains("y")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("text")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("type")) __score8++;
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

            global::G.Click? click = default;
            global::G.DoubleClick? doubleClick = default;
            global::G.Drag? drag = default;
            global::G.KeyPress? keyPress = default;
            global::G.Move? move = default;
            global::G.Screenshot? screenshot = default;
            global::G.Scroll? scroll = default;
            global::G.Type? type = default;
            global::G.Wait? wait = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Click), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Click> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Click).Name}");
                        click = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DoubleClick), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DoubleClick> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DoubleClick).Name}");
                        doubleClick = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Drag), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Drag> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Drag).Name}");
                        drag = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.KeyPress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.KeyPress> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.KeyPress).Name}");
                        keyPress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Move), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Move> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Move).Name}");
                        move = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Screenshot), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Screenshot> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Screenshot).Name}");
                        screenshot = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Scroll), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Scroll> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Scroll).Name}");
                        scroll = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Type), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Type> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Type).Name}");
                        type = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Wait), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Wait> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Wait).Name}");
                        wait = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (click == null && doubleClick == null && drag == null && keyPress == null && move == null && screenshot == null && scroll == null && type == null && wait == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Click), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Click> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Click).Name}");
                    click = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DoubleClick), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DoubleClick> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DoubleClick).Name}");
                    doubleClick = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Drag), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Drag> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Drag).Name}");
                    drag = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.KeyPress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.KeyPress> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.KeyPress).Name}");
                    keyPress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Move), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Move> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Move).Name}");
                    move = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Screenshot), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Screenshot> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Screenshot).Name}");
                    screenshot = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Scroll), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Scroll> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Scroll).Name}");
                    scroll = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Type), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Type> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Type).Name}");
                    type = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Wait), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Wait> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Wait).Name}");
                    wait = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ComputerAction(
                click,

                doubleClick,

                drag,

                keyPress,

                move,

                screenshot,

                scroll,

                type,

                wait
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ComputerAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Click), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Click?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Click).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Click!, typeInfo);
            }
            else if (value.IsDoubleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DoubleClick), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DoubleClick?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DoubleClick).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DoubleClick!, typeInfo);
            }
            else if (value.IsDrag)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Drag), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Drag?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Drag).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Drag!, typeInfo);
            }
            else if (value.IsKeyPress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.KeyPress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.KeyPress?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.KeyPress).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.KeyPress!, typeInfo);
            }
            else if (value.IsMove)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Move), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Move?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Move).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Move!, typeInfo);
            }
            else if (value.IsScreenshot)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Screenshot), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Screenshot?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Screenshot).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Screenshot!, typeInfo);
            }
            else if (value.IsScroll)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Scroll), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Scroll?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Scroll).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Scroll!, typeInfo);
            }
            else if (value.IsType)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Type), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Type?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Type).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Type!, typeInfo);
            }
            else if (value.IsWait)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Wait), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Wait?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Wait).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Wait!, typeInfo);
            }
        }
    }
}