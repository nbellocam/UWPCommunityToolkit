﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Graph;

namespace Microsoft.Toolkit.Uwp.Services.MicrosoftGraph
{
    /// <summary>
    ///  Class using Office 365 Microsoft Graph Messages API
    /// </summary>
    [Obsolete("This class is being deprecated. Please use the .NET Standard Library counterpart found in Microsoft.Toolkit.Services.")]
    public class MicrosoftGraphServiceMessage : Toolkit.Services.MicrosoftGraph.MicrosoftGraphServiceMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MicrosoftGraphServiceMessage"/> class.
        /// </summary>
        /// <param name="graphClientProvider">Instance of GraphClientService class</param>
        /// <param name="currentConnectedUser">Instance of Graph.User class</param>
        public MicrosoftGraphServiceMessage(GraphServiceClient graphClientProvider, User currentConnectedUser)
            : base(graphClientProvider, currentConnectedUser)
        {
        }
    }
}
