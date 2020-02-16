namespace NWN
{
    public enum AnimationEngine
    {
        Pause                              = 0,
        Ready                              = 1,
        Walking                            = 2,
        WalkingBackwards                   = 3,
        Running                            = 4,
        KnockdownFront                     = 5,
        DeadFront                          = 6,
        KnockdownButt                      = 7,
        DeadButt                           = 8,
        Attack                             = 9,
        Throw                              = 10,
        Dodge                              = 11,
        Parry                              = 12,
        Shield                             = 13,
        Damage                             = 14,
        Conjure1                           = 15,
        Conjure2                           = 16,
        Cast1                              = 17,
        Cast2                              = 18,
        Cast3                              = 19,
        Cast4                              = 20,
        Open                               = 21,
        Closed                             = 22,
        Spasm                              = 23,
        CombatStepFront                    = 24,
        CombatStepBack                     = 25,
        CombatStepLeft                     = 26,
        CombatStepRight                    = 27,
        Taunt                              = 28,
        OverlayGreeting                    = 29,
        OverlayListen                      = 30,
        Meditate                           = 32,
        Worship                            = 33,
        OverlaySalute                      = 34,
        Bow                                = 35,
        Sitting                            = 36,
        Steal                              = 37,
        OverlayTalkNormal                  = 38,
        OverlayTalkPleading                = 39,
        OverlayTalkForceful                = 40,
        OverlayTalkLaugh                   = 41,
        CombatStepDummy                    = 42,
        AttackDummy                        = 43,
        VictoryFighter                     = 44,
        VictoryMage                        = 45,
        VictoryThief                       = 46,
        SitCrossLegs                       = 47,
        LookFar                            = 48,
        CombatStepDummyFB                  = 49,
        Opened1                            = 50,
        Opened2                            = 51,
        Pause2                             = 52,
        HeadTurnLeft                       = 53,
        HeadTurnRight                      = 54,
        PauseScratchHead                   = 55,
        PauseBored                         = 56,
        PauseTired                         = 57,
        PauseDrunk                         = 58,
        GetLow                             = 59,
        GetMid                             = 60,
        Cast5                              = 61,
        Flown                              = 62,
        Arrived                            = 63,
        OverlayDrink                       = 70,
        OverlayRead                        = 71,
        Destroyed                          = 72,
        PlaceableActivated                 = 73,
        PlaceableDeactivated               = 74,
        PlaceableOpened                    = 75,
        PlaceableClosed                    = 76,
        DamageStab                         = 77,
        WalkingLeft                        = 78,
        WalkingRight                       = 79,
        TurnOnSpotRight                    = 80,
        TurnOnSpotLeft                     = 81,
        CombatTurnRight                    = 82,
        CombatTurnLeft                     = 83,
        WalkingForwardLeft                 = 84,
        WalkingForwardRight                = 85,
        RunningForwardLeft                 = 86,
        RunningForwardRight                = 87,
        DialogNoAnim                       = 88,
        FakeAttack                         = 89,
        FakeDodgeSide                      = 90,
        FakeDodgeDuck                      = 91,
        Whirlwind                          = 92,
        SpasmLooping                       = 93,
        Flown2                             = 94,
        Arrived2                           = 95,
        CastCreature                       = 96,
        Custom1                            = 97,
        Custom2                            = 98,
        DamageLeft                         = 99,
        DamageRight                        = 100,
        Custom3                            = 101,
        Custom4                            = 102,
        Custom5                            = 103,
        Custom6                            = 104,
        Custom7                            = 105,
        Custom8                            = 106,
        Custom9                            = 107,
        Custom10                           = 108,
        Custom11                           = 109,
        Custom12                           = 110,
        Custom13                           = 111,
        Custom14                           = 112,
        Custom15                           = 113,
        Custom16                           = 114,
        Custom17                           = 115,
        Custom18                           = 116,
        Custom19                           = 117,
        Custom20                           = 118,
        Mount1                             = 119,
        Dismount1                          = 120,
    }

    public enum AnimationScript
    {

        //  Looping animation constants.
        Looping_Pause = 0,
        Looping_Pause2 = 1,
        Looping_Listen = 2,
        Looping_Meditate = 3,
        Looping_Worship = 4,
        Looping_LookFar = 5,
        Looping_SitChair = 6,
        Looping_SitCross = 7,
        Looping_TalkNormal = 8,
        Looping_TalkPleading = 9,
        Looping_TalkForceful = 10,
        Looping_TalkLaughing = 11,
        Looping_GetLow = 12,
        Looping_GetMid = 13,
        Looping_PauseTired = 14,
        Looping_PauseDrunk = 15,
        Looping_DeadFront = 16,
        Looping_DeadBack = 17,
        Looping_Conjure1 = 18,
        Looping_Conjure2 = 19,
        Looping_Spasm = 20,
        Looping_Custom1 = 21,
        Looping_Custom2 = 22,
        Looping_Custom3 = 23,
        Looping_Custom4 = 24,
        Looping_Custom5 = 25,
        Looping_Custom6 = 26,
        Looping_Custom7 = 27,
        Looping_Custom8 = 28,
        Looping_Custom9 = 29,
        Looping_Custom10 = 30,
        Looping_Custom11 = 31,
        Looping_Custom12 = 32,
        Looping_Custom13 = 33,
        Looping_Custom14 = 34,
        Looping_Custom15 = 35,
        Looping_Custom16 = 36,
        Looping_Custom17 = 37,
        Looping_Custom18 = 38,
        Looping_Custom19 = 39,
        Looping_Custom20 = 40,
        Mount1 = 41,
        Dismount1 = 42,
        //  Fire and forget animation constants.
        Fireforget_HeadTurnLeft = 100,
        Fireforget_HeadTurnRight = 101,
        Fireforget_PauseScratchHead = 102,
        Fireforget_PauseBored = 103,
        Fireforget_Salute = 104,
        Fireforget_Bow = 105,
        Fireforget_Steal = 106,
        Fireforget_Greeting = 107,
        Fireforget_Taunt = 108,
        Fireforget_Victory1 = 109,
        Fireforget_Victory2 = 110,
        Fireforget_Victory3 = 111,
        Fireforget_Read = 112,
        Fireforget_Drink = 113,
        Fireforget_Dodge_side = 114,
        Fireforget_Dodge_duck = 115,
        Fireforget_Spasm = 116,
        //  Placeable animation constants
        Placeable_Activate = 200,
        Placeable_Deactivate = 201,
        Placeable_Open = 202,
        Placeable_Close = 203,
        //  Door animation constants
        Door_Close = 204,
        Door_Open1 = 205,
        Door_Open2 = 206,
        Door_Destroy = 207,
    }

}
