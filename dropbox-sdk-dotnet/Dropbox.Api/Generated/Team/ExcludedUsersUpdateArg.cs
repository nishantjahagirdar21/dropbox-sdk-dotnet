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
    /// <para>Argument of excluded users update operation. Should include a list of users to
    /// add/remove (according to endpoint), Maximum size of the list is 1000 users.</para>
    /// </summary>
    public class ExcludedUsersUpdateArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ExcludedUsersUpdateArg> Encoder = new ExcludedUsersUpdateArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ExcludedUsersUpdateArg> Decoder = new ExcludedUsersUpdateArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ExcludedUsersUpdateArg" />
        /// class.</para>
        /// </summary>
        /// <param name="users">List of users to be added/removed.</param>
        public ExcludedUsersUpdateArg(col.IEnumerable<UserSelectorArg> users = null)
        {
            var usersList = enc.Util.ToList(users);

            this.Users = usersList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ExcludedUsersUpdateArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public ExcludedUsersUpdateArg()
        {
        }

        /// <summary>
        /// <para>List of users to be added/removed.</para>
        /// </summary>
        public col.IList<UserSelectorArg> Users { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ExcludedUsersUpdateArg" />.</para>
        /// </summary>
        private class ExcludedUsersUpdateArgEncoder : enc.StructEncoder<ExcludedUsersUpdateArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ExcludedUsersUpdateArg value, enc.IJsonWriter writer)
            {
                if (value.Users.Count > 0)
                {
                    WriteListProperty("users", value.Users, writer, global::Dropbox.Api.Team.UserSelectorArg.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ExcludedUsersUpdateArg" />.</para>
        /// </summary>
        private class ExcludedUsersUpdateArgDecoder : enc.StructDecoder<ExcludedUsersUpdateArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ExcludedUsersUpdateArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ExcludedUsersUpdateArg Create()
            {
                return new ExcludedUsersUpdateArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ExcludedUsersUpdateArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "users":
                        value.Users = ReadList<UserSelectorArg>(reader, global::Dropbox.Api.Team.UserSelectorArg.Decoder);
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
