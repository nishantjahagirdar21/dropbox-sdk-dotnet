// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The values correspond to entries in <see cref="Feature" />. You may get different
    /// value according to your Dropbox for Business plan.</para>
    /// </summary>
    public class FeatureValue
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FeatureValue> Encoder = new FeatureValueEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FeatureValue> Decoder = new FeatureValueDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FeatureValue" /> class.</para>
        /// </summary>
        public FeatureValue()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is UploadApiRateLimit</para>
        /// </summary>
        public bool IsUploadApiRateLimit
        {
            get
            {
                return this is UploadApiRateLimit;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UploadApiRateLimit, or <c>null</c>.</para>
        /// </summary>
        public UploadApiRateLimit AsUploadApiRateLimit
        {
            get
            {
                return this as UploadApiRateLimit;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is HasTeamSharedDropbox</para>
        /// </summary>
        public bool IsHasTeamSharedDropbox
        {
            get
            {
                return this is HasTeamSharedDropbox;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a HasTeamSharedDropbox, or <c>null</c>.</para>
        /// </summary>
        public HasTeamSharedDropbox AsHasTeamSharedDropbox
        {
            get
            {
                return this as HasTeamSharedDropbox;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is HasTeamFileEvents</para>
        /// </summary>
        public bool IsHasTeamFileEvents
        {
            get
            {
                return this is HasTeamFileEvents;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a HasTeamFileEvents, or <c>null</c>.</para>
        /// </summary>
        public HasTeamFileEvents AsHasTeamFileEvents
        {
            get
            {
                return this as HasTeamFileEvents;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FeatureValue" />.</para>
        /// </summary>
        private class FeatureValueEncoder : enc.StructEncoder<FeatureValue>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FeatureValue value, enc.IJsonWriter writer)
            {
                if (value is UploadApiRateLimit)
                {
                    WriteProperty(".tag", "upload_api_rate_limit", writer, enc.StringEncoder.Instance);
                    UploadApiRateLimit.Encoder.EncodeFields((UploadApiRateLimit)value, writer);
                    return;
                }
                if (value is HasTeamSharedDropbox)
                {
                    WriteProperty(".tag", "has_team_shared_dropbox", writer, enc.StringEncoder.Instance);
                    HasTeamSharedDropbox.Encoder.EncodeFields((HasTeamSharedDropbox)value, writer);
                    return;
                }
                if (value is HasTeamFileEvents)
                {
                    WriteProperty(".tag", "has_team_file_events", writer, enc.StringEncoder.Instance);
                    HasTeamFileEvents.Encoder.EncodeFields((HasTeamFileEvents)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FeatureValue" />.</para>
        /// </summary>
        private class FeatureValueDecoder : enc.UnionDecoder<FeatureValue>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FeatureValue" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FeatureValue Create()
            {
                return new FeatureValue();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override FeatureValue Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "upload_api_rate_limit":
                        return UploadApiRateLimit.Decoder.DecodeFields(reader);
                    case "has_team_shared_dropbox":
                        return HasTeamSharedDropbox.Decoder.DecodeFields(reader);
                    case "has_team_file_events":
                        return HasTeamFileEvents.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The upload api rate limit object</para>
        /// </summary>
        public sealed class UploadApiRateLimit : FeatureValue
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UploadApiRateLimit> Encoder = new UploadApiRateLimitEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UploadApiRateLimit> Decoder = new UploadApiRateLimitDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UploadApiRateLimit" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public UploadApiRateLimit(UploadApiRateLimitValue value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UploadApiRateLimit" />
            /// class.</para>
            /// </summary>
            private UploadApiRateLimit()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public UploadApiRateLimitValue Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UploadApiRateLimit" />.</para>
            /// </summary>
            private class UploadApiRateLimitEncoder : enc.StructEncoder<UploadApiRateLimit>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UploadApiRateLimit value, enc.IJsonWriter writer)
                {
                    WriteProperty("upload_api_rate_limit", value.Value, writer, global::Dropbox.Api.Team.UploadApiRateLimitValue.Encoder);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UploadApiRateLimit" />.</para>
            /// </summary>
            private class UploadApiRateLimitDecoder : enc.StructDecoder<UploadApiRateLimit>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="UploadApiRateLimit"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UploadApiRateLimit Create()
                {
                    return new UploadApiRateLimit();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(UploadApiRateLimit value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "upload_api_rate_limit":
                            value.Value = global::Dropbox.Api.Team.UploadApiRateLimitValue.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The has team shared dropbox object</para>
        /// </summary>
        public sealed class HasTeamSharedDropbox : FeatureValue
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<HasTeamSharedDropbox> Encoder = new HasTeamSharedDropboxEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<HasTeamSharedDropbox> Decoder = new HasTeamSharedDropboxDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="HasTeamSharedDropbox" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public HasTeamSharedDropbox(HasTeamSharedDropboxValue value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="HasTeamSharedDropbox" />
            /// class.</para>
            /// </summary>
            private HasTeamSharedDropbox()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public HasTeamSharedDropboxValue Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="HasTeamSharedDropbox" />.</para>
            /// </summary>
            private class HasTeamSharedDropboxEncoder : enc.StructEncoder<HasTeamSharedDropbox>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(HasTeamSharedDropbox value, enc.IJsonWriter writer)
                {
                    WriteProperty("has_team_shared_dropbox", value.Value, writer, global::Dropbox.Api.Team.HasTeamSharedDropboxValue.Encoder);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="HasTeamSharedDropbox" />.</para>
            /// </summary>
            private class HasTeamSharedDropboxDecoder : enc.StructDecoder<HasTeamSharedDropbox>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="HasTeamSharedDropbox"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override HasTeamSharedDropbox Create()
                {
                    return new HasTeamSharedDropbox();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(HasTeamSharedDropbox value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "has_team_shared_dropbox":
                            value.Value = global::Dropbox.Api.Team.HasTeamSharedDropboxValue.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The has team file events object</para>
        /// </summary>
        public sealed class HasTeamFileEvents : FeatureValue
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<HasTeamFileEvents> Encoder = new HasTeamFileEventsEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<HasTeamFileEvents> Decoder = new HasTeamFileEventsDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="HasTeamFileEvents" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public HasTeamFileEvents(HasTeamFileEventsValue value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="HasTeamFileEvents" />
            /// class.</para>
            /// </summary>
            private HasTeamFileEvents()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public HasTeamFileEventsValue Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="HasTeamFileEvents" />.</para>
            /// </summary>
            private class HasTeamFileEventsEncoder : enc.StructEncoder<HasTeamFileEvents>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(HasTeamFileEvents value, enc.IJsonWriter writer)
                {
                    WriteProperty("has_team_file_events", value.Value, writer, global::Dropbox.Api.Team.HasTeamFileEventsValue.Encoder);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="HasTeamFileEvents" />.</para>
            /// </summary>
            private class HasTeamFileEventsDecoder : enc.StructDecoder<HasTeamFileEvents>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="HasTeamFileEvents"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override HasTeamFileEvents Create()
                {
                    return new HasTeamFileEvents();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(HasTeamFileEvents value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "has_team_file_events":
                            value.Value = global::Dropbox.Api.Team.HasTeamFileEventsValue.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : FeatureValue
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
