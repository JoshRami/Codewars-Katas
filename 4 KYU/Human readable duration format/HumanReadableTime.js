const datesInSeconds = {
  year: 31536000,
  day: 86400,
  hour: 3600,
  minute: 60,
  second: 1,
};
const dates = {
  year: 0,
  day: 0,
  hour: 0,
  minute: 0,
  second: 0,
};

function formatDuration(seconds) {
  let formattedString = "";
  let timesArray = [];
  if (seconds === 0) {
    return "now";
  }

  for (let time in dates) {
    [dates[time], seconds] = getTime(seconds, datesInSeconds[time]);
    if (dates[time] > 0) {
      timesArray.push(
        dates[time] === 1
          ? //The purpose for add ','at the end of string is to split the string into an array to give the definitive format
            `${dates[time]} ${time}`
          : `${dates[time]} ${time + "s"}`
      );
    }
  }
  for (let index = 0; index < timesArray.length; index++) {
    if (timesArray.length === 1) {
      formattedString = timesArray.toString();
      return formattedString;
    }
    if (index === timesArray.length - 2) {
      formattedString = formattedString.concat(
        `${timesArray[index]} `,
        "and ",
        timesArray[timesArray.length - 1]
      );
      return formattedString;
    }
    formattedString = formattedString.concat(`${timesArray[index]}`, ", ");
  }
  return formattedString;
}

function getTime(seconds, time) {
  let ntimes = 0;
  while (seconds >= time) {
    seconds -= time;
    ntimes++;
  }
  return [ntimes, seconds];
}
