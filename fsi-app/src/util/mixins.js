const mixins = {
	methods: {
		route: function (route) {
			let url = 'http://localhost:4321/api'

			if (route.charAt(0) === '/') {
				return url + route
			}

			return url + '/' + route
		}
	}
}

export default mixins
