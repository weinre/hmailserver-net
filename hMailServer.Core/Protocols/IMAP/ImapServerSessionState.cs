﻿namespace hMailServer.Core.Protocols.IMAP
{
    class ImapServerSessionState
    {
        public void Reset()
        {

        }

        public bool IsCommandValid(ImapCommand command)
        {
            switch (command)
            {
                default:
                    return false;
            }
        }
    }
}
