// Capitalizes all the words in a string
export function capitalize(value) {
	if (!value) {
		return ''
	}

	return value.replace(/\b\w/g, l => l.toUpperCase())
}

// Formats value to currency
export function currency(value) {
	if (!value) {
		return ''
	}

	return '$' + value.toFixed(2)
}
