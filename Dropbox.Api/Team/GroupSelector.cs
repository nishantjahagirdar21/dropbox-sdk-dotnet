// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>Argument for selecting a single group, either by group_id or by external group
    /// ID.</para>
    /// </summary>
    public class GroupSelector
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupSelector> Encoder = new GroupSelectorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupSelector> Decoder = new GroupSelectorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupSelector" /> class.</para>
        /// </summary>
        public GroupSelector()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is GroupId</para>
        /// </summary>
        public bool IsGroupId
        {
            get
            {
                return this is GroupId;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a GroupId, or <c>null</c>.</para>
        /// </summary>
        public GroupId AsGroupId
        {
            get
            {
                return this as GroupId;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is GroupExternalId</para>
        /// </summary>
        public bool IsGroupExternalId
        {
            get
            {
                return this is GroupExternalId;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a GroupExternalId, or <c>null</c>.</para>
        /// </summary>
        public GroupExternalId AsGroupExternalId
        {
            get
            {
                return this as GroupExternalId;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupSelector" />.</para>
        /// </summary>
        private class GroupSelectorEncoder : enc.StructEncoder<GroupSelector>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupSelector value, enc.IJsonWriter writer)
            {
                if (value is GroupId)
                {
                    WriteProperty(".tag", "group_id", writer, enc.StringEncoder.Instance);
                    GroupId.Encoder.EncodeFields((GroupId)value, writer);
                    return;
                }
                if (value is GroupExternalId)
                {
                    WriteProperty(".tag", "group_external_id", writer, enc.StringEncoder.Instance);
                    GroupExternalId.Encoder.EncodeFields((GroupExternalId)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupSelector" />.</para>
        /// </summary>
        private class GroupSelectorDecoder : enc.UnionDecoder<GroupSelector>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupSelector" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupSelector Create()
            {
                return new GroupSelector();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override GroupSelector Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "group_id":
                        return GroupId.Decoder.DecodeFields(reader);
                    case "group_external_id":
                        return GroupExternalId.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Group ID.</para>
        /// </summary>
        public sealed class GroupId : GroupSelector
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<GroupId> Encoder = new GroupIdEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<GroupId> Decoder = new GroupIdDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="GroupId" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public GroupId(string value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="GroupId" /> class.</para>
            /// </summary>
            private GroupId()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public string Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="GroupId" />.</para>
            /// </summary>
            private class GroupIdEncoder : enc.StructEncoder<GroupId>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(GroupId value, enc.IJsonWriter writer)
                {
                    WriteProperty("group_id", value.Value, writer, enc.StringEncoder.Instance);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="GroupId" />.</para>
            /// </summary>
            private class GroupIdDecoder : enc.StructDecoder<GroupId>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="GroupId" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override GroupId Create()
                {
                    return new GroupId();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(GroupId value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "group_id":
                            value.Value = enc.StringDecoder.Instance.Decode(reader);
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
        /// <para>External ID of the group.</para>
        /// </summary>
        public sealed class GroupExternalId : GroupSelector
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<GroupExternalId> Encoder = new GroupExternalIdEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<GroupExternalId> Decoder = new GroupExternalIdDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="GroupExternalId" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public GroupExternalId(string value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="GroupExternalId" />
            /// class.</para>
            /// </summary>
            private GroupExternalId()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public string Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="GroupExternalId" />.</para>
            /// </summary>
            private class GroupExternalIdEncoder : enc.StructEncoder<GroupExternalId>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(GroupExternalId value, enc.IJsonWriter writer)
                {
                    WriteProperty("group_external_id", value.Value, writer, enc.StringEncoder.Instance);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="GroupExternalId" />.</para>
            /// </summary>
            private class GroupExternalIdDecoder : enc.StructDecoder<GroupExternalId>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="GroupExternalId" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override GroupExternalId Create()
                {
                    return new GroupExternalId();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(GroupExternalId value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "group_external_id":
                            value.Value = enc.StringDecoder.Instance.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }
    }
}