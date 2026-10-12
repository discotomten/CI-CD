set -euo pipefail

FILE="README.md"
MAX=${1:-2000} #Max antal tecken

if [ ! -f "$FILE" ]; then
echo "::error::$FILE saknas"
exit 1
fi

COUNT=(wc -m < "$FILE")
echo "$FILE har $COUNT tecken (max $MAX)"

if ["$COUNT" -gt "$MAX" ]; then
echo "::error file=$FILE::$FILE är för lång: $COUNT tecken, max är $MAX"
exit 1
fi