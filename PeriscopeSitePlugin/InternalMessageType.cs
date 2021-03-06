﻿namespace PeriscopeSitePlugin
{
    internal enum InternalMessageType
    {
        Chat_UNKNOWN,
        Chat_CHAT,
        Chat_HEART,
        Chat_JOIN,
        Chat_LOCATION,
        Chat_BROADCAST_ENDED,
        Chat_INVITE_FOLLOWERS,
        Chat_BROADCAST_STARTED_LOCALLY,
        Chat_BROADCASTER_UPLOADED_REPLAY,
        Chat_TIMESTAMP,
        Chat_LOCAL_PROMPT_TO_FOLLOW_BROADCASTER,
        Chat_LOCAL_PROMPT_TO_SHARE_BROADCAST,
        Chat_BROADCASTER_BLOCKED_VIEWER,
        Chat_SUBSCRIBER_SHARED_ON_TWITTER,
        Chat_SUBSCRIBER_BLOCKED_VIEWER,
        Chat_SUBSCRIBER_SHARED_ON_FACEBOOK,
        Chat_SCREENSHOT,
        Chat_SENTENCE,
        Chat_SPARKLE,
        Chat_FIRST_SPARKLE,
        Chat_COMMENT_MUTED,
        Chat_HYDRA_CONTROL_MESSAGE,
        Chat_COMMENT_MUTED_BY_MODERATOR,
        Chat_COMMENT_UNMUTED_BY_MODERATOR,
        Chat_USER_CHAT,
        Chat_SYSTEM,
        Control_JOIN,
        Control_LEAVE,
        Control_ROSTER,
        Control_PRESENCE,
        Control_BAN,
    }
}
