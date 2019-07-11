export const AuthModule = {
	namespaced: true,

	state: {
		username: '',
		name: '',
		role: '',
		token: ''
	},

	getters: {
		username: state => state.username,
		name: state => state.name,
		role: state => state.role,
		token: state => state.token
	},

	mutations: {
		setUsername(state, username) {
			state.username = username
		},

		setName(state, name) {
			state.name = name
		},

		setRole(state, role) {
			state.role = role
		},

		setToken(state, token) {
			state.token = token
		}
	}
}
