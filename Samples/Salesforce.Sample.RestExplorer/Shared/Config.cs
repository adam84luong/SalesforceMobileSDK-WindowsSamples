/*
 * Copyright (c) 2014-present, salesforce.com, inc.
 * All rights reserved.
 * Redistribution and use of this software in source and binary forms, with or
 * without modification, are permitted provided that the following conditions
 * are met:
 * - Redistributions of source code must retain the above copyright notice, this
 * list of conditions and the following disclaimer.
 * - Redistributions in binary form must reproduce the above copyright notice,
 * this list of conditions and the following disclaimer in the documentation
 * and/or other materials provided with the distribution.
 * - Neither the name of salesforce.com, inc. nor the names of its contributors
 * may be used to endorse or promote products derived from this software without
 * specific prior written permission of salesforce.com, inc.
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE
 * LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
 * SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
 * CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
 * POSSIBILITY OF SUCH DAMAGE.
 */

using Windows.UI;
using Salesforce.SDK.Settings;
using System;

namespace Salesforce.Sample.RestExplorer.Shared
{
    public class Config : SalesforceConfig
    {
        /// <summary>
        ///     In using this sample you should create a connected app, and replace the ClientId with an id from the generated app.
        /// </summary>
        public override string ClientId
        {
            get { return "3MVG9Iu66FKeHhINkB1l7xt7kR8czFcCTUhgoA8Ol2Ltf1eYHOU4SqQRSEitYFDUpqRWcoQ2.dBv_a1Dyu5xa"; }
        }

        public override string CallbackUrl
        {
            get { return "testsfdc:///mobilesdk/detect/oauth/done"; }
        }

        public override string[] Scopes
        {
            get { return new[] {"api"}; }
        }

        public override Int32 LoginBackgroundColor
        {
            get { return ColorToInt32(Colors.DarkOrange); }
        }

        public override System.Uri LoginBackgroundLogo
        {
            get { return null; }
        }

        public override string ApplicationTitle
        {
            get { return "Salesforce RestExplorer Sample"; }
        }

        /// <summary>
        /// Set this propeert to true if you want the Title to show up on start screen of the app.
        /// </summary>
        public override bool IsApplicationTitleVisible
        {
            get { return true; }
        }

        private static Int32 ColorToInt32(Color color)
        {
            return (Int32)((color.A << 24) | (color.R << 16) |
                          (color.G << 8) | (color.B << 0));
        }
    }
}