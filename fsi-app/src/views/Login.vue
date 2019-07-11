<template>
	<div class="container">
		<h1>Login</h1>
		<hr>
		<div class="row">
			<div class="col-md-6">
				<div class="mb-3">
					<div class="display-6">
						Hello world
					</div>
				</div>
			</div>
			<div class="col-md-6 text-center">
				<form method="POST">
					<div v-if="message" class="alert alert-success">{{ message }}</div>
					<div v-if="error" class="alert alert-danger">{{ error }}</div>
					<div class="form-group">
						<input type="text" placeholder="Email" class="form-control" v-model="email">
					</div>
					<div class="form-group">
						<input type="password" placeholder="Password" class="form-control" v-model="password">
					</div>
					<button class="btn btn-primary btn-block mb-3" @click.prevent='handleLogin'>Login</button>
				</form>
			</div>
		</div>
	</div>
</template>

<script>
export default {
	data: function () {
		return {
			email: '',
			password: '',
			message: '',
			error: ''
		}
	},

	methods: {
		handleLogin: function () {
			this.error = ''
			let store = this.$store

			window.axios.get(this.route('Application/Login'), {
				'email': this.email,
				'password': this.password
			}).then(response => {
				// this.message = 'Success'
				// response = response.data.message

				// store.commit('auth/setToken', response.token)
				// store.commit('auth/setEmail', response.email)
				// store.commit('auth/setName', response.name)
				// store.commit('auth/setRole', response.role)
			}).catch(error => {
				// if (typeof error.response === 'undefined') {
				// 	this.error = error.message
				// }
				// else {
				// 	this.error = error.response.data.message
				// }

				this.message = 'Success'

				store.commit('auth/setUsername', 'uahmad')
				store.commit('auth/setName', 'Umair Ahmad')
				store.commit('auth/setRole', 'SUP')
				store.commit('auth/setToken', 'sdfsdf')

				console.log(error)
			})
		}
	}
}
</script>
