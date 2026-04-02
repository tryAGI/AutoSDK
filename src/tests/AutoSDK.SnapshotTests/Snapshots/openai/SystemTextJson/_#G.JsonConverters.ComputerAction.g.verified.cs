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
                        click = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Click>(__rawJson, options);
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
                        doubleClick = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DoubleClick>(__rawJson, options);
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
                        drag = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Drag>(__rawJson, options);
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
                        keyPress = global::System.Text.Json.JsonSerializer.Deserialize<global::G.KeyPress>(__rawJson, options);
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
                        move = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Move>(__rawJson, options);
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
                        screenshot = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Screenshot>(__rawJson, options);
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
                        scroll = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Scroll>(__rawJson, options);
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
                        type = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Type>(__rawJson, options);
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
                        wait = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Wait>(__rawJson, options);
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
                    click = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Click>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    doubleClick = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DoubleClick>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    drag = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Drag>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    keyPress = global::System.Text.Json.JsonSerializer.Deserialize<global::G.KeyPress>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    move = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Move>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    screenshot = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Screenshot>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    scroll = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Scroll>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    type = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Type>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    wait = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Wait>(__rawJson, options);
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

            if (value.IsClick)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Click, typeof(global::G.Click), options);
            }
            else if (value.IsDoubleClick)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DoubleClick, typeof(global::G.DoubleClick), options);
            }
            else if (value.IsDrag)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Drag, typeof(global::G.Drag), options);
            }
            else if (value.IsKeyPress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.KeyPress, typeof(global::G.KeyPress), options);
            }
            else if (value.IsMove)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Move, typeof(global::G.Move), options);
            }
            else if (value.IsScreenshot)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Screenshot, typeof(global::G.Screenshot), options);
            }
            else if (value.IsScroll)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Scroll, typeof(global::G.Scroll), options);
            }
            else if (value.IsType)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Type, typeof(global::G.Type), options);
            }
            else if (value.IsWait)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Wait, typeof(global::G.Wait), options);
            }
        }
    }
}