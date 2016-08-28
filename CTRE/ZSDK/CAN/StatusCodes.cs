using System;
using Microsoft.SPOT;

namespace CTRE.ZSDK.CAN
{
    public enum StatusCodes
    {
        OK = 0,

        /* Error Codes */
        CAN_MSG_STALE = 1,
        CAN_TX_FULL = -1,
        CAN_INVALID_PARAM = -2,
        CAN_MSG_NOT_FOUND = -3,
        CAN_NO_MORE_TX_JOBS = -4,
        CAN_NO_SESSIONS_AVAIL = -5,
        CAN_OVERFLOW = -6,

        GENERAL_ERROR = -100,
        SIG_NOT_UPDATED = -200,

        /* Gadgeteer Port Error Codes */
        /* These include errors between ports and modules */
        GEN_PORT_ERROR = -300,
        PORT_MODULE_TYPE_MISMATCH = -301,

        /* Gadgeteer Module Error Codes */
        /* These apply only to the module units themselves */
        GEN_MODULE_ERROR = -400,
        MODULE_NOT_INIT_SET_ERROR = -401,
        MODULE_NOT_INIT_GET_ERROR = -402
    }
}
