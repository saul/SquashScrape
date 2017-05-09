namespace SquashScrape

open System

module Config =
    
    /// Name of the Google account to send emails from
    let googleAccount = "your.account.here@gmail.com"

    /// Address to send the email notifications (including exception messages) to
    let notificationAddress = googleAccount

    /// Calendar IDs to use to determine busy-ness
    let calendarIds =
        [|
        googleAccount
        "another-calendar@group.calendar.google.com"
        |]
    
    /// Path to the gym connect
    let gymUrl = "http://gym.uclu.org/connect/"

    /// Authentication details for the gym connect service
    let loginUsername = "<username here>"
    let loginPassword = "<password here>"

    /// Times to check the calendar for busy-ness
    let busyCheckStartTime = TimeSpan(16, 00, 00)
    let busyCheckEndTime = TimeSpan(0, 23, 59, 59, 999)

    /// Times to search for free activity slots to book
    let activityBookStartTime = "18:00"
    let activityBookEndTime = "19:00"
