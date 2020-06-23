export class Kata {
  static squareDigits(num: number) {
    return Number(
      num
        .toString()
        .split("")
        .map((number) => Number(number) ** 2)
        .join("")
    );
  }
}
