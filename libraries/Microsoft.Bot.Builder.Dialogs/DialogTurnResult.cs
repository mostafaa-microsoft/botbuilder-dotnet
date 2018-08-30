﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Bot.Builder.Dialogs
{
    /// <summary>
    /// Result returned to the caller of one of the various stack manipulation methods and used to
    /// return the result from a final call to `DialogContext.end()` to the bots logic.
    /// </summary>
    public class DialogTurnResult
    {
        public DialogTurnResult(DialogStatus status, object result = null)
        {
            Status = status;
            Result = result;
        }

        /// <summary>
        /// Gets or sets the current status of the stack.
        /// </summary>
        /// <value>
        /// The current status of the stack.
        /// </value>
        public DialogStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the result returned by a dialog that was just ended.
        /// This will only be populated in certain cases:
        ///
        /// - The bot calls `dc.begin()` to start a new dialog and the dialog ends immediately.
        /// - The bot calls `dc.continue()` and a dialog that was active ends.
        ///
        /// In all cases where it's populated, [active](#active) will be `false`.
        /// </summary>
        /// <value>
        /// The result returned by a dialog that was just ended.
        /// </value>
        public object Result { get; set; }
    }
}
